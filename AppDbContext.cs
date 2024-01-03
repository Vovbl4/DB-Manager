using Microsoft.EntityFrameworkCore;
using Pyrofest_Manager_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyrofest_Manager_App
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Item> items { get; set; } = null;
        public DbSet<Category> categories { get; set; } = null;
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;username=root;password=root;database=Pyrofest");
        }
    }
}
