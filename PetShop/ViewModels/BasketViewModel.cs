using PetShop.BLL;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PetShop.ViewModels
{
    class BasketViewModel
    {
        public List<Product> products;

        public IProductLogic productLogic;

        public event PropertyChangedEventHandler PropertyChanged;

        public BasketViewModel()
        {
            productLogic = new ProductLogic();

            products = PropertyController.basketProducts;
        }

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
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
    }
}
