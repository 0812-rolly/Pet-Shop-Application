using PetShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PetShop.BLL
{
    public class ProductLogic : IProductLogic
    {
        public Task<Product> GetProduct(int id)
        {
            var product = PetShopDatabase.GetProduct(id);

            return product;
        }

        public Task<List<Product>> GetProductsQuery()
        {
            var products = PetShopDatabase.GetAllProductsQuery();

            return products;
        }

        public Task<List<Product>> GetProductsQuery(string petType, string group)
        {
            var products = PetShopDatabase.GetProductsQuery(petType, group);

            return products;
        }

        public async Task<Dictionary<Product, int>> GetProductsFromCart()
        {
            var products = await PetShopDatabase.GetProductsFromCart();

            Dictionary<Product, int> cartProducts = new Dictionary<Product, int>();

            foreach(BasketItem b in products)
            {
                Product product = await PetShopDatabase.GetProduct(b.ProductId);
                cartProducts.Add(product, b.Quantity);
            }

            return cartProducts;
        }

        public async Task<Dictionary<Product, int>> UpdateProductsCart()
        {
            var products = await PetShopDatabase.GetProductsFromCart();

            Dictionary<Product, int> productsToBasket = new Dictionary<Product, int>();

            foreach(BasketItem b in products)
            {
                var prod = await PetShopDatabase.GetProduct(b.ProductId);
                productsToBasket.Add(prod, b.Quantity);
            }

            PropertyController.BasketListProvider.BasketProducts = productsToBasket;

            return productsToBasket;
        }

        public void AddProduct(Product product)
        {
            PetShopDatabase.InsertProduct(product);
        }

        public void AddProductToCart(Product product)
        {
            BasketItem basketItem = new BasketItem()
            {
                ProductId = product.Id,
                Quantity = 1
            };

            PetShopDatabase.InsertToCart(basketItem);
        }

        public void IncreaseProductAsync(Product product, int amount)
        {
            PetShopDatabase.InsertProduct(product);
        }

        public async void RemoveProductFromCart(Product product)
        {
            BasketItem basketItem = await PetShopDatabase.GetProductFromCart(product.Id);

            PetShopDatabase.RemoveFromCart(basketItem);
        }

        public async void UpdateProductInCart(Product product, int newQuantity)
        {
            BasketItem basketItem = await PetShopDatabase.GetProductFromCart(product.Id);

            basketItem.Quantity = newQuantity;

           PetShopDatabase.UpdateInCart(basketItem);
        }

        public void UpdateProductInDatabase(Product product, int newInStock)
        {
            product.InStock = newInStock;

            PetShopDatabase.UpdateInDatabase(product);
        }

        public async void FromCartToOrder()
        {
            List<BasketItem> cartItems = await PetShopDatabase.GetProductsFromCart();

            List<Product> allProducts = await GetProductsQuery();

            foreach(Product p in allProducts)
            {
                try
                {
                    BasketItem basketItem = cartItems.Find(x => x.ProductId == p.Id);
                    UpdateProductInDatabase(p, p.InStock - basketItem.Quantity);
                    RemoveProductFromCart(p);

                    int y = 5;
                }
                catch (NullReferenceException)
                {
                    continue;
                }
            }
        }

        public Task<bool> ReduceProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
