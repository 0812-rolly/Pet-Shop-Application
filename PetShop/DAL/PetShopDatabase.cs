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

            //string databasePath = "PetShop.db";
            string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PetShop.db");

            if (File.Exists(databasePath))
                File.Delete(databasePath);

            Database = new SQLiteAsyncConnection(databasePath, SQLiteOpenFlags.Create | SQLiteOpenFlags.FullMutex | SQLiteOpenFlags.ReadWrite);

            Database.CreateTableAsync<Product>().Wait();

            //await Database.CreateTableAsync<Product>();
        }

        public static async Task<Product> GetProduct(int id)
        {
            await Init();

            var product = await Database.FindAsync<Product>(id);

            return product;
        }

        public static async Task<List<Product>> GetProductsQuery(string petType, string group)
        {
            await Init();

            var products = Database.Table<Product>().Where(x => x.Group == group && x.PetType == petType);

            List<Product> result = await products.ToListAsync();

            return result;
        }

        public static async void InsertProduct(Product product)
        {
            await Init();

            int result = await Database.InsertAsync(product);

            List<Product> products = await Database.Table<Product>().ToListAsync();
        }
    }
}
