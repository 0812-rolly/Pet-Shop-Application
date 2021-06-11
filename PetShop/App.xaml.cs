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
            //Device.SetFlags(new[] { "Shapes_Experimental" });
            //DependencyService.Register<MockDataStore>();

            DoShit();

            NavigationPage np = new NavigationPage(new ProductsPage("Кошки", "Влажный корм"));

            MainPage = np;
        }

        public async void DoShit()
        {
            Product prod1 = new Product();
            prod1.group = "Влажный корм";
            prod1.petType = "Кошки";
            prod1.name = "CHEATOS";


            Product prod2 = new Product();
            prod2.group = "Влажный корм";
            prod2.petType = "Кошки";
            prod2.name = "HAMBO";

            Product prod3 = new Product();
            prod3.group = "Влажный корм";
            prod3.petType = "Кошки";
            prod3.name = "ABOBA";

            productLogic.IncreaseProductAsync(prod1);
            productLogic.IncreaseProductAsync(prod2);
            productLogic.IncreaseProductAsync(prod3);

            List<Product> products = new List<Product>();

            products = await productLogic.GetProductsQuery("Кошки", "Влажный корм");
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
