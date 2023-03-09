using DIDemo.Models;

namespace DIDemo.Service
{
    public interface IProductsService
    {
        IEnumerable<Products> GetAllProducts();
        Products GetProductsById(int id);
        int AddProduct(Products prod);
        int UpdateProduts(Products prod);
        int DeleteProduct(int id);
    }
}
