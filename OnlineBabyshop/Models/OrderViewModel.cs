using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Models
{
    public class OrderViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public Order Order { get; set; }

        public OrderDetails OrderDetails { get; set; }


    }
}

