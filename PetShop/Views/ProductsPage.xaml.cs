using PetShop.BLL;
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
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        public ProductsPage(string petType_, string group)
        {
            PropertyController.PetType = petType_;
            PropertyController.Group = group;

            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var product = e.CurrentSelection.FirstOrDefault() as Product;

            if (product == null)
                return;

            //await Navigation.PushAsync(new ProductFullPage(product));
            await Navigation.PushAsync(new ProductFullPage(product));

            ((CollectionView)sender).SelectedItem = null;
        }

    }
}