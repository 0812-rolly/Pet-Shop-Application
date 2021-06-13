using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.BLL
{
    public interface IProductLogic
    {
        void IncreaseProductAsync(Product product, int amount);
        Task<bool> ReduceProductAsync(Product product);
        
        void AddProduct(Product product);
        void AddProductToCart(Product product);

        void RemoveProductFromCart(Product product);
        
        Task<Dictionary<Product, int>> UpdateProductsCart();
        Task<Product> GetProduct(int id);
        Task<List<Product>> GetProductsQuery();
        Task<List<Product>> GetProductsQuery(string petType, string group);
        Task<Dictionary<Product, int>> GetProductsFromCart();

        void UpdateProductInCart(Product product, int newQuantity);
        void UpdateProductInDatabase(Product product, int newInStock);
        void FromCartToOrder();
    }
}
