using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PetShop.Models
{
    [Table("Product")]
    public class Product : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PetType { get; set; }
        public string Group { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Composition { get; set; }
        public double Weight { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }
        public string Image { get; set; }

        public Product(int id, string name, string petType, string group, string shortDescription, string longDescription, string composition, int weight, int price, int inStock, string image)
        {
            this.Id = id;
            this.Name = name;
            this.PetType = petType;
            this.Group = group;
            this.ShortDescription = shortDescription;
            this.LongDescription = longDescription;
            this.Composition = composition;
            this.Weight = weight;
            this.Price = price;
            Image = image;
            InStock = inStock;
        }

        public Product()
        {

        }
    }
}
