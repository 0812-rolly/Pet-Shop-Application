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
            name_label.Text = product.Name;
            shortDesc_Label.Text = product.ShortDescription;
            weight_label.Text = "Вес: " + product.Weight.ToString() + " кг";
            instock_label.Text = "В наличии: " + product.InStock.ToString();
            price_label.Text = product.Price + " ₽";
            img.Source = product.Image;
            longDesc_label.Text = product.LongDescription;
            composition_label.Text = product.Composition;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BasketPage()); // need logic
        }
    }
}