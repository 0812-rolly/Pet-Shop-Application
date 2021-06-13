using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using PetShop.Models;
using System.Runtime.CompilerServices;

namespace PetShop.BLL
{
    public class BasketProductsProvider : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Dictionary<Product, int> basketProducts = new Dictionary<Product, int>();

        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            return;
        }

        public Dictionary<Product, int> BasketProducts
        {
            get => basketProducts;

            set
            {
                if (basketProducts != value)
                {
                    basketProducts = value;
                    NotifyPropertyChanged(nameof(basketProducts));
                }
            }
        }
    }
}
