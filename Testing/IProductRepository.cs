using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
        Product GetProductById(int id);
        IEnumerable<Product> GetAllProducts();
        void UpdateProduct(Product product);

        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();

    }
}

