using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PetShop.Views
{
    public partial class Ordering : ContentPage
    {
        public Ordering()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void btn_Ordering_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThankYouPage());
        }
    }
}
