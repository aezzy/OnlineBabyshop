using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Models
{
    public class Category

    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        //list of products
        public virtual ICollection<Product> Products { get; set; }
    }
}
