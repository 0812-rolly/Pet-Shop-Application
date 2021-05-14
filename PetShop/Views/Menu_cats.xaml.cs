using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace PetShop.Views
{
    public partial class Menu_cats : ContentPage
    {
        public Menu_cats()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped_WetFood(System.Object sender, System.EventArgs e)
        {
            GotoProductsPage("Кошки", "Влажный корм");
        }

        void TapGestureRecognizer_Tapped_DryFood(System.Object sender, System.EventArgs e)
        {
            GotoProductsPage("Кошки", "Сухой корм");
        }

        void TapGestureRecognizer_Tapped_Toys(System.Object sender, System.EventArgs e)
        {
            GotoProductsPage("Кошки", "Игрушки");
        }

        void TapGestureRecognizer_Tapped_Medicine(System.Object sender, System.EventArgs e)
        {
            GotoProductsPage("Кошки", "Лекарства");
        }

        public async void GotoProductsPage(string petType, string group)
        {
            await Navigation.PushAsync(new ProductsPage(petType, group));
        }
    }
}
