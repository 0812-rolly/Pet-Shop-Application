using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Models
{
    [Table("BasketItem")]
    public class BasketItem
    {
        [PrimaryKey]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
