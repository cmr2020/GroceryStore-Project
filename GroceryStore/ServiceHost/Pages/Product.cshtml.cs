
using _01_RemalQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ProductModel : PageModel
    {
        public ProductQueryModel Product;
        private readonly IProductQuery _productQuery;
    

        public ProductModel(IProductQuery productQuery)
        {
            _productQuery = productQuery;
           
        }

        public void OnGet(string id)
        {
            Product = _productQuery.GetProductDetails(id);
        }

     
    }
}
