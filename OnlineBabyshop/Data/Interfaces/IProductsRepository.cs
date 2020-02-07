using OnlineBabyshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Data.Interfaces
{
   public interface IProductsRepository
    {
        IEnumerable<Product> Products { get; }

        Product GetProductById(int productId);
    }
}
