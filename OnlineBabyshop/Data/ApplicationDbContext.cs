using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineBabyshop.Models;

namespace OnlineBabyshop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OnlineBabyshop.Models.Category> Category { get; set; }
        public DbSet<OnlineBabyshop.Models.Gender> Gender { get; set; }
        public DbSet<OnlineBabyshop.Models.Product> Product { get; set; }
        public DbSet<OnlineBabyshop.Models.Size> Size { get; set; }


        public DbSet<OnlineBabyshop.Models.ShoppingCartItems> ShoppingCartItems { get; set; }

        public DbSet<OnlineBabyshop.Models.OrderDetails> OrderDetails { get; set; }
        public DbSet<OnlineBabyshop.Models.Order> Order { get; set; }


        //public DbSet<OnlineBabyshop.Models.ShoppingCart> ShoppingCart { get; set; }




    }
}
