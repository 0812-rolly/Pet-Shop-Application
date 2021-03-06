using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            btn_Login.Clicked += (sender, args) => OnButtonClicked(sender, args);
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            bool error = false;

            if (etr_PhoneNumber.Text == null || etr_PhoneNumber.Text == "" ||
                etr_PhoneNumber.Text.Length < 11)
            {
                etr_PhoneNumber.PlaceholderColor = Color.FromHex("#f56b62");
                error = true;
            }

            if (Cb_Agreement.IsChecked == false)
            {
                error = true;
            }

            if (error == false)
            {
                Models.User.Phone = etr_PhoneNumber.Text;
                await Navigation.PushAsync(new LoginConfirmPage());

            }

        }
    }
}