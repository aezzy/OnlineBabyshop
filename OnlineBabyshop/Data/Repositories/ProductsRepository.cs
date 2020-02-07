using Microsoft.EntityFrameworkCore;
using OnlineBabyshop.Data;
using OnlineBabyshop.Data.Interfaces;
using OnlineBabyshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Data.Repositories

{
    public class ProductsRepository: IProductsRepository
    {

        private readonly ApplicationDbContext _context;
        public ProductsRepository(ApplicationDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IEnumerable<Product> Products => _context.Product.Include(c => c.category);



        //public IEnumerable<Drink> PreferredDrinks => _appDbContext.Drinks.Where(p => p.IsPreferredDrink).Include(c => c.Category);

        public Product GetProductById(int productId) => _context.Product.FirstOrDefault(p => p.ProductId == productId);


    }
}
