using _0_Framework.Application;
using _0_Framework.Infrastructure;
using AccountMangement.Infrastructure.EFCore;
using ShopManagement.Application.Contracts;
using ShopManagement.Application.Contracts.Order;
using ShopManagement.Domain.OrderAgg;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class OrderRepository : RepositoryBase<long, Order>, IOrderRepository
    {
        private readonly ShopContext _context;
        private readonly AccountContext _accountContext;

        public OrderRepository(ShopContext context, AccountContext accountContext) : base(context)
        {
            _context = context;
            _accountContext = accountContext;
        }

        public double GetAmountBy(long id)
        {
            var order = _context.Orders
                  .Select(x => new { x.PayAmount, x.ID })
                  .FirstOrDefault(x => x.ID == id);
            if (order != null)
                return order.PayAmount;
            return 0;
        }

        public List<OrderItemViewModel> GetItems(long orderId)
        {
            var products = _context.Products.Select(x => new { x.ID, x.Name }).ToList();
            var order = _context.Orders.FirstOrDefault(x => x.ID == orderId);
            if (order == null)
                return new List<OrderItemViewModel>();

            var items = order.Items.Select(x => new OrderItemViewModel
            {
                Id = x.ID,
                Count = x.Count,
                DiscountRate = x.DiscountRate,
                OrderId = x.OrderId,
                ProductId = x.ProductId,
                UnitPrice = x.UnitPrice
            }).ToList();

            foreach (var item in items)
            {
                item.Product = products.FirstOrDefault(x => x.ID == item.ProductId)?.Name;
            }

            return items;
        }

        public List<OrderViewModel> Search(OrderSearchModel searchModel)
        {
            var accounts = _accountContext.Accounts.Select(x => new { x.ID, x.Fullname }).ToList();
            var query = _context.Orders.Select(x => new OrderViewModel
            {
                Id = x.ID,
                AccountId = x.AccountId,
                DiscountAmount = x.DiscountAmount,
                IsCanceled = x.IsCanceled,
                IsPaid = x.IsPaid,
                IssueTrackingNo = x.IssueTrackingNo,
                PayAmount = x.PayAmount,
                PaymentMethodId = x.PaymentMethod,
                RefId = x.RefId,
                TotalAmount = x.TotalAmount,
                CreationDate = x.CreationDate.ToFarsi()
            });

            query = query.Where(x => x.IsCanceled == searchModel.IsCanceled);

            if (searchModel.AccountId > 0) query = query.Where(x => x.AccountId == searchModel.AccountId);

            var orders = query.OrderByDescending(x => x.Id).ToList();
            foreach (var order in orders)
            {
                order.AccountFullName = accounts.FirstOrDefault(x => x.ID == order.AccountId)?.Fullname;
                order.PaymentMethod = PaymentMethod.GetBy(order.PaymentMethodId).Name;
            }

            return orders;
        }
    }
}
