using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            InitializeFields();
        }

        public void InitializeFields()
        {
            etr_LastName.Text = Models.User.SecondName;
            etr_FirstName.Text = Models.User.FirstName;
            etr_Patronymic.Text = Models.User.Patronymic;
            etr_PhoneNumber.Text = Models.User.Phone;
            etr_Email.Text = Models.User.Email;
        }

        void btn_SaveProfile_Clicked(System.Object sender, System.EventArgs e)
        {
            Models.User.SecondName = etr_LastName.Text;
            Models.User.FirstName = etr_FirstName.Text;
            Models.User.Patronymic = etr_Patronymic.Text;
            Models.User.Phone = etr_PhoneNumber.Text;
            Models.User.Email = etr_Email.Text;
        }
    }
}