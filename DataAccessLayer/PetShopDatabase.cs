using SQLite;
using System;
using System.IO;
using System.Reflection;

namespace DataAccessLayer
{
    public class PetShopDatabase
    {
        static SQLiteAsyncConnection Database;

        public PetShopDatabase()
        {
            string DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PetShopDB.db");

            Assembly assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            Stream embeddedDatabaseStream = assembly.GetManifestResourceStream("PetShop.PetShopDB.db");
        }
    }
}
