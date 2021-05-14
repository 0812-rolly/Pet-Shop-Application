using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PetShop.Models
{
    [Table("Product")]
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string name { get; set; }
        public string petType { get; set; }
        public string group { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public string composition { get; set; }
        public int weight { get; set; }
        public int price { get; set; }
        public int InStock { get; set; }

        public Product(int id, string name, string petType, string group, string shortDescription, string longDescription, string composition, int weight, int price, int inStock)
        {
            this.id = id;
            this.name = name;
            this.petType = petType;
            this.group = group;
            this.shortDescription = shortDescription;
            this.longDescription = longDescription;
            this.composition = composition;
            this.weight = weight;
            this.price = price;
            InStock = inStock;
        }

        public Product()
        {

        }
    }
}
