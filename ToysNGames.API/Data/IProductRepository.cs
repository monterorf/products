using System.Collections.Generic;
using System.Threading.Tasks;
using ToysNGames.API.Models;

namespace ToysNGames.API.Data
{
    public interface IProductRepository
    {
         void CreateProduct(Product product);
         Task<List<Product>> GetProducts();
         Task<Product> GetProduct(int Id);
         Task<Product> EditProduct(int Id, Product product);
         void DeleteProduct(int Id);
         Task<bool> SaveAll();
         
         
    }
}