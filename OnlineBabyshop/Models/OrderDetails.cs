using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Models
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }

        public int ShoppingCartItemsId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public decimal OrderTotal { get; set; }
        public decimal Price { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
        public virtual List<ShoppingCartItems> ShoppingCartItems { get; set; }
    }
}

