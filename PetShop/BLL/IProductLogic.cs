using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.BLL
{
    public interface IProductLogic
    {
        Task<bool> ReduceProductAsync(Product product);

        void AddProduct(Product product);
        void IncreaseProductAsync(Product product);
        Task<Product> GetProduct(int id);
        Task<List<Product>> GetProductsQuery(string petType, string group);
    }
}
