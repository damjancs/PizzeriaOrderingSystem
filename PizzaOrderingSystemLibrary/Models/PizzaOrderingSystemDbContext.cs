using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystemLibrary.Models
{
    public class PizzaOrderingSystemDbContext : DbContext
    {
        private string _connectionString =
            "Server=(localdb)\\mssqllocaldb;Database=PizzeriaDb;Trusted_Connection=True;";
        public DbSet<DishModel> Dish { get; set; }
        public DbSet<DishAdditionModel> DishAddition { get; set; }
        public DbSet<OrderItemModel> OrderItem { get; set; }
        public DbSet<OrderModel> Order { get; set; }
        public DbSet<UserModel> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishModel>()
                .Property(d => d.Name)
                .IsRequired();

            modelBuilder.Entity<DishAdditionModel>()
                .Property(dm => dm.Name)
                .IsRequired();
            modelBuilder.Entity<UserModel>()
                .HasIndex(u => u.Username)
                .IsUnique();
            modelBuilder.Entity<UserModel>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
