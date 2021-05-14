using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PetShop.BLL;
using System.IO;
//using MvvmHelpers.Commands;

namespace PetShop.ViewModels
{
    class ProductViewModel
    {
        public List<Product> products;

        public IProductLogic productLogic;

        public ProductViewModel()
        {
            productLogic = new ProductLogic();
            //using (StreamWriter sr = new StreamWriter("../output.txt"))
            //{
            //    sr.WriteLine("wewew");
            //}

            ICommand com = this.Refresh;

        }

        public List<Product> Products
        {
            get { return products; }
            set
            {
                products = value;
            }
        }

        //async Task Refresh()
        //{
        //    throw new Exception("wwww");

        //    Products = await productLogic.GetProductsQuery(PropertyController.PetType, PropertyController.Group);
        //}

        public ICommand Refresh
        {
            get
            {
                return new Command(async () =>
                {
                    throw new Exception("Here's JohnnY!");
                    Products = await productLogic.GetProductsQuery(PropertyController.PetType, PropertyController.Group);
                });
            }
        }
    }
}
