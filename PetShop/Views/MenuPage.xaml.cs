﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PetShop.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            Cats.Source = "Cats.png";
            Dogs.Source = "Dogs.png";
            Birds.Source = "Birds.png";
            Rodents.Source = "Rodents.png";
        }
    }
}
