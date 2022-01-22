using _01_RemalQuery.Contracts;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class CheckoutModel : PageModel
    {
        public Cart Cart;
        public const string CookieName = "cart-items";
        private readonly ICartService _cartService;
        private readonly ICartCalculatorService _cartCalculatorService;
        //public List<CartItem> CartItems;

        public CheckoutModel(ICartCalculatorService cartCalculatorService, ICartService cartService)
        {
            _cartCalculatorService = cartCalculatorService;
            _cartService = cartService;
            //CartItems = new List<CartItem>();
        }

        public void OnGet()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            foreach (var item in cartItems)
                item.CalculateTotalItemPrice();

            Cart = _cartCalculatorService.ComputeCart(cartItems);
            _cartService.Set(Cart);
        }

        public IActionResult OnGetPay()
        {
            var cart = _cartService.Get();

            return RedirectToPage("/Checkout");
        }


        }
}
