using DIDemo.Models;
using DIDemo.Repository;

namespace DIDemo.Service
{
    public class ProductsService : IProductsService
    {
        // Add Constuctor and Update the Constructor
        private readonly IProductsRepository repo;
        public ProductsService(IProductsRepository repo)
        {
            this.repo = repo;
        }
        public int AddProduct(Products prod)
        {
            return repo.AddProduct(prod);
        }

        public int DeleteProduct(int id)
        {
            return repo.DeleteProduct(id);
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return repo.GetAllProducts();
        }

        public Products GetProductsById(int id)
        {
            return repo.GetProductsById(id);
        }

        public int UpdateProduts(Products prod)
        {
            return repo.UpdateProduts(prod);
        }
    }
}
