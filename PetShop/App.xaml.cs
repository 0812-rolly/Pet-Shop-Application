﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PetShop.Services;
using PetShop.Views;

namespace PetShop
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            //Device.SetFlags(new[] { "Shapes_Experimental" });
            //DependencyService.Register<MockDataStore>();
            NavigationPage np = new NavigationPage(new HelloPage());

            MainPage = np;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
