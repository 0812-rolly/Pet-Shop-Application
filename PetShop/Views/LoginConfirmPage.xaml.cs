using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginConfirmPage : ContentPage
    {
        public LoginConfirmPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            bool error = false;

            if (etr_SmsCode.Text == null || etr_SmsCode.Text == "")
            {
                etr_SmsCode.PlaceholderColor = Color.FromHex("#f56b62");
                error = true;
            }

            if (error == false)
                await Navigation.PushAsync(new LoginSuccessPage());
        }
    }
}