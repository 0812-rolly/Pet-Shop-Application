using PetShop.BLL;
using PetShop.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PetShop.Views
{
    public partial class BasketPage : ContentPage
    {

        public BasketPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            //if (PropertyController.BasketFlag)
            //{
            //    PropertyController.BasketFlag = false;
            //    Navigation.PushAsync(new BasketPage());
            //}
            //else
            //{
            //    PropertyController.BasketFlag = true;
            //}

            BasketViewModel viewModel = BindingContext as BasketViewModel;
            viewModel.Refresh();
            SetTotalPrice();

        }

       public void SetTotalPrice()
        {
            BasketViewModel viewModel = BindingContext as BasketViewModel;
            int totalPrice = viewModel.CountTotalPrice();
            TotalPrice.Text = totalPrice.ToString() + " ₽";
        }

        void TapGestureRecognizer_Tapped_Basket(System.Object sender, System.EventArgs e)
        {

        }

        void DecreaseQuantity(System.Object sender, System.EventArgs e)
        {
            
        }

        void IncreaseQuantity(System.Object sender, System.EventArgs e)
        {

        }

        void BuyAndOrder(System.Object sender, System.EventArgs e)
        {

        }
    }
}
