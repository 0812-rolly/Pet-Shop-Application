using PetShop.Models;
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
    public partial class ProductFullPage : ContentPage
    {
        Product product;
        public ProductFullPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        public ProductFullPage(Product product) : this()
        {
            this.product = product;
            SetFields();
        }

        private void SetFields()
        {
            
        }
    }
}