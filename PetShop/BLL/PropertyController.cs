using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.BLL
{
    public static class PropertyController
    {
        public static string PetType {get;set; }
        public static string Group { get; set; }
        public static List<Product> basketProducts { get; set; }
    }
}
