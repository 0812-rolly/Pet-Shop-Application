using PetShop.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace PetShop
{
    public class PetShopDatabase
    {
        public static SQLiteAsyncConnection Database;

        static async Task Init()
        {
            if (Database != null)
                return;

            string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PetShop.db");

            if (File.Exists(databasePath))
                File.Delete(databasePath);

            Database = new SQLiteAsyncConnection(databasePath, SQLiteOpenFlags.Create | SQLiteOpenFlags.FullMutex | SQLiteOpenFlags.ReadWrite);

            Database.CreateTableAsync<Product>().Wait();
            Database.CreateTableAsync<BasketItem>().Wait();
        }

        public static async Task<Product> GetProduct(int id)
        {
            await Init();

            var product = await Database.FindAsync<Product>(id);

            return product;
        }

        public static async Task<BasketItem> GetProductFromCart(int id)
        {
            await Init();

            var basketItem = Database.Table<BasketItem>().FirstOrDefaultAsync(x => x.ProductId == id);

            return await basketItem;
        }

        public static async Task<List<Product>> GetProductsQuery(string petType, string group)
        {
            await Init();

            var products = Database.Table<Product>().Where(x => x.Group == group && x.PetType == petType);

            List<Product> result = await products.ToListAsync();

            return result;
        }

        public static async Task<List<Product>> GetAllProductsQuery()
        {
            await Init();

            var products = Database.Table<Product>();

            List<Product> result = await products.ToListAsync();

            return result;
        }

        public static async Task<List<BasketItem>> GetProductsFromCart()
        {
            await Init();

            var products = await Database.Table<BasketItem>().ToListAsync();

            return products;
        }

        public static async void InsertProduct(Product product)
        {
            await Init();

            int result = await Database.InsertAsync(product);
        }

        public static async void InsertToCart(BasketItem basketItem)
        {
            await Init();

            await Database.InsertAsync(basketItem);
        }

        public static async void RemoveFromCart(BasketItem basketItem)
        {
            await Init();

            await Database.DeleteAsync(basketItem);
        }

        public static async void RemoveFromCartAll()
        {
            await Init();

            await Database.DeleteAllAsync<BasketItem>();
        }

        public static async void UpdateInDatabase(Product product)
        {
            await Init();

            int result = await Database.UpdateAsync(product);
        }

        public static async void UpdateInCart(BasketItem basketItem)
        {
            await Init();

            int result = await Database.UpdateAsync(basketItem);
        }
    }
}
