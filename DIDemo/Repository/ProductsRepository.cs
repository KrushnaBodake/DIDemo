using DIDemo.Data;
using DIDemo.Models;

namespace DIDemo.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ApplicationDbContext db;
        public ProductsRepository(ApplicationDbContext db)
        {
            this.db= db;    
        }
        public int AddProduct(Products prod)
        {
            int result = 0;
            db.Product.Add(prod);
            result= db.SaveChanges();
            return result;

            
        }

        public int DeleteProduct(int id)
        {
            int result = 0;

            var prod = db.Product.Where(x => x.Id == id).FirstOrDefault();
            if (prod != null)
            {
                db.Product.Remove(prod);
                result = db.SaveChanges();
            }
            return result;


        }

        public IEnumerable<Products> GetAllProducts()
        {
            return db.Product.ToList();

        }

        public Products GetProductsById(int id)
        {
            var prod = db.Product.Where(x => x.Id == id).FirstOrDefault();
            return prod;

        }

        public int UpdateProduts(Products prod)
        {
            int result = 0;

            var p = db.Product.Where(x => x.Id == prod.Id).FirstOrDefault();
            if (p != null)
            {
                p.Pname = prod.Pname;
                p.Company = prod.Company;
                p.Price = prod.Price;
                result = db.SaveChanges();
            }
            return result;

        }
    }
}
