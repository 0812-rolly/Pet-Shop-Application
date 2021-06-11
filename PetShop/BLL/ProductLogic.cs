using PetShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.BLL
{
    public class ProductLogic : IProductLogic
    {
        public Task<Product> GetProduct(int id)
        {
            var product = PetShopDatabase.GetProduct(id);

            return product;
        }

        public Task<List<Product>> GetProductsQuery(string petType, string group)
        {
            var products = PetShopDatabase.GetProductsQuery(petType, group);

            return products;
        }

        public void IncreaseProductAsync(Product product)
        {
            PetShopDatabase.InsertProduct(product);
        }

        public Task<bool> ReduceProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
