using PetShop.BLL;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PetShop.ViewModels
{
    public class BasketViewModel : INotifyPropertyChanged
    {
        public Dictionary<Product, int> products;

        public IProductLogic productLogic;

        public event PropertyChangedEventHandler PropertyChanged;

        public BasketViewModel()
        {
            productLogic = new ProductLogic();
            PropertyController.basketViewModel = this;

            Refresh();
        }

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public Dictionary<Product, int> Products
        {
            get { return products; }
            set
            {
                if (products != value)
                {
                    products = value;
                    OnPropertyChanged(nameof(Products));
                }
            }
        }

        public async void Refresh()
        {
            Products = await productLogic.GetProductsFromCart();

            return;
        }
    }
}
