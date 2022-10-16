using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PetApp.Entity;
using System.ComponentModel;

namespace PetApp.Data.Concrete.EfCore
{
    public class MainContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Pet> Pets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=petAppDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PetCategory>().HasKey(c => new { c.PetId, c.CategoryId });
        }
    }
}
