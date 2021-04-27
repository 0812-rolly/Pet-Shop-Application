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
    public partial class TabbedMenu : TabbedPage
    {
        public TabbedMenu()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            BarTextColor = Color.FromHex("#a3a19e");
            SelectedTabColor = Color.FromHex("#FB6A18");
            UnselectedTabColor = Color.FromHex("#a3a19e");
            
        }
    }
}