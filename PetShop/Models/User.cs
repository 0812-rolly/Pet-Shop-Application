using System;
namespace PetShop.Models
{
    public static class User
    {
        private static string secondname;
        private static string firstname;
        private static string patronymic;
        private static string phone;
        private static string email;

        public static string SecondName
        {
            get => secondname;
            set => secondname = value;
        }

        public static string FirstName
        {
            get => firstname;
            set => firstname = value;
        }

        public static string Patronymic
        {
            get => patronymic;
            set => patronymic = value;
        }

        public static string Phone
        {
            get => phone;
            set => phone = value;
        }

        public static string Email
        {
            get => email;
            set => email = value;
        }
    }
}
