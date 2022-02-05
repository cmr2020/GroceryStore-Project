using _0_Framework.Infrastructure;
using ShopManagement.Domain.OrderAgg;
using System.Linq;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class OrderRepository : RepositoryBase<long, Order>, IOrderRepository
    {
        private readonly ShopContext _context;
        public OrderRepository(ShopContext context) : base(context)
        {
            _context = context;
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
    }
}
