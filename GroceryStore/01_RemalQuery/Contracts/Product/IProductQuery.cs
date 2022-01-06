using System.Collections.Generic;


namespace _01_RemalQuery.Contracts.Product
{
    public interface IProductQuery
    {     
        List<ProductQueryModel> GetLatestArrivals();
        List<ProductQueryModel> Search(string value);
    }
}
