using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PetShop.Views
{
    public partial class ThankYouPage : ContentPage
    {
        public ThankYouPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void ToMenuPage(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
            await Navigation.PushAsync(new MenuPage());
        }
    }
}
