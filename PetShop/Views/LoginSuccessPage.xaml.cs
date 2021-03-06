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
    public partial class LoginSuccessPage : ContentPage
    {
        public LoginSuccessPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void btn_Proceed_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedMenu());
        }
    }
}