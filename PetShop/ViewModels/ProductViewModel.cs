using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PetShop.BLL;
using System.IO;
using System.ComponentModel;
//using MvvmHelpers.Commands;

namespace PetShop.ViewModels
{
    class ProductViewModel : INotifyPropertyChanged
    {
        public List<Product> products;

        public IProductLogic productLogic;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ProductViewModel()
        {
            productLogic = new ProductLogic();

            Task.Run(()=>Refresh());
        }

        public List<Product> Products
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
            Products = await productLogic.GetProductsQuery(PropertyController.PetType, PropertyController.Group);
            return;
        }
    }
}
