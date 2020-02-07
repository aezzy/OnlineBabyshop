using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDisc { get; set; }
        public int Price { get; set; }
        public virtual string ImgUrl { get; set; }
        //public IEnumerable<Product> Products { get; set; }

        //connect to the gender class
        public int GenderId { get; set; }
        public virtual Gender gender { get; set; }

        //connect to the size class
        public int SizeId { get; set; }
        public virtual Size size { get; set; }

        //connect to the category class
        public int CategoryId { get; set; }
        public virtual Category category  { get; set; }
    }
}
