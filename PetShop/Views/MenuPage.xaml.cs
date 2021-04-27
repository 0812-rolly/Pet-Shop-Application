using System;
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



        void TapGestureRecognizer_Tapped_Cats(System.Object sender, System.EventArgs e)
        {
            GotoPageCats();
        }

        void TapGestureRecognizer_Tapped_Dogs(System.Object sender, System.EventArgs e)
        {
            GotoPageDogs();
        }

        void TapGestureRecognizer_Tapped_Birds(System.Object sender, System.EventArgs e)
        {
            GotoPageBirds();
        }

        void TapGestureRecognizer_Tapped_Rodents(System.Object sender, System.EventArgs e)
        {
            GotoPageRodents();
        }



        public async void GotoPageCats()
        {
            await Navigation.PushAsync(new Menu_cats());
        }

        public async void GotoPageDogs()
        {
            await Navigation.PushAsync(new Menu_dogs());
        }

        public async void GotoPageBirds()
        {
            await Navigation.PushAsync(new Menu_birds());
        }

        public async void GotoPageRodents()
        {
            await Navigation.PushAsync(new Menu_rodents());
        }
    }
}
