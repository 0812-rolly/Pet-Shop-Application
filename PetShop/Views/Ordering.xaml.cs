using PetShop.BLL;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PetShop.Views
{

    public partial class Ordering : ContentPage
    {
        IProductLogic productLogic = new ProductLogic();
        public Ordering()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void btn_Ordering_Clicked(object sender, EventArgs e)
        {
            productLogic.FromCartToOrder();
            await Navigation.PushAsync(new ThankYouPage());
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            radioButton.IsChecked = true;
        }

        private void RadioButton_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            radioButton.IsChecked = true;
        }
    }
}
