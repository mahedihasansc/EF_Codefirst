using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodefirstApp.Models
{
    public class App : DbContext
    {
        public App(DbContextOptions<App> a) : 
            base(a)
        {
        }

        public DbSet<Suppliers> Supplier { get; set; } 
        public DbSet<Products> Product { get; set; }
    }
}
