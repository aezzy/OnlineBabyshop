using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Models
{
    public class ProductsListView
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategoryName { get; set; }
        public int CurrentCategory { get; set; }
    }
}
