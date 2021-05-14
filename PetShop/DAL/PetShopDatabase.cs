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
        static SQLiteAsyncConnection Database;

        static async Task Init()
        {
            if (Database != null)
                return;

            string DatabasePath = "PetShopDB.db";
            Database = new SQLiteAsyncConnection(DatabasePath);

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

            var products = Database.Table<Product>().Where(x => x.group == group && x.petType == petType);

            var result = products.ToListAsync();

            return await result;
        }
    }
}
