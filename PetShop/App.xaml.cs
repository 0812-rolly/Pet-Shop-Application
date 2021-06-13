using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PetShop.Services;
using PetShop.Views;
using System.IO;
using PetShop.BLL;
using PetShop.Models;
using System.Collections.Generic;

namespace PetShop
{
    public partial class App : Application
    {
        public IProductLogic productLogic = new ProductLogic();

        public App()
        {
            InitializeComponent();
            DataLoader.LoadData();

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
