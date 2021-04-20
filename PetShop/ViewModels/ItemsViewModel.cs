using System;

using Xamarin.Forms;

namespace PetShop.ViewModels
{
    public class ItemsViewModel : ContentView
    {
        public ItemsViewModel()
        {
            Content = new Label { Text = "Hello ContentView" };
        }
    }
}

