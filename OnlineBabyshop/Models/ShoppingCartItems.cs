using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Models
{
    public class ShoppingCartItems
    {
        public int ShoppingCartItemsId { get; set; }
        public Product Product { get; set; }

        //quantity = amount
        public int Amount { get; set; }
        public decimal OrderTotal { get; set; }
        //public int OrderDetailsId { get; set; }
        //public virtual OrderDetails OrderDetails { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
