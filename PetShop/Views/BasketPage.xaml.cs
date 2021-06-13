using PetShop.BLL;
using PetShop.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PetShop.Views
{
    public partial class BasketPage : ContentPage
    {
        IProductLogic productLogic = new ProductLogic();

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
            int totalPrice = SetTotalPrice();

            if (totalPrice == 0)
                btn_Proceed.IsEnabled = false;
            else
                btn_Proceed.IsEnabled = true;
        }

        public int SetTotalPrice()
        {
            BasketViewModel viewModel = BindingContext as BasketViewModel;
            int totalPrice = viewModel.CountTotalPrice();

            TotalPrice.Text = totalPrice.ToString() + " ₽";

            return totalPrice;
        }

        void DeleteAll(System.Object sender, System.EventArgs e)
        {
            productLogic.RemoveProductsFromCart();
            BasketViewModel viewModel = BindingContext as BasketViewModel;
            viewModel.Refresh();
            SetTotalPrice();
        }

        public async void BuyAndOrder(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Ordering());
        }
    }
}
