using PetShop.Models;
using PetShop.ViewModels;
using PetShop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace PetShop.BLL
{
    public static class PropertyController
    {
        public static string PetType { get; set; }
        public static string Group { get; set; }
        public static BasketProductsProvider provider = new BasketProductsProvider();
        public static bool BasketFlag{get;set;}

        public static BasketProductsProvider BasketListProvider
        {
            get
            {
                return provider;
            }
        }

        public static BasketViewModel basketViewModel { get; set; }

        public static MenuPage MenuPage { get; set; }

    }
}
