using DIDemo.Models;

namespace DIDemo.Repository
{
    public interface IProductsRepository
    {
        IEnumerable<Products> GetAllProducts();
        Products GetProductsById(int id);
        int AddProduct(Products prod);
        int UpdateProduts(Products prod);
        int DeleteProduct(int id);
    }
}
