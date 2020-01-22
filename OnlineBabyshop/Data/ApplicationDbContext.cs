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
    }
}
