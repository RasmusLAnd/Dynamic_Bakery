using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test__Backery.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pastries> Pastries { get; set;  }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewDetail> ReviewDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //making my Categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Bread", Description = "Lovely bread made with love" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cakes", Description = "Delicious cakes for every day" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Cakes for special occasions", Description = "Get ready to PARTY!!!" });

            //making my Pastries
            modelBuilder.Entity<Pastries>().HasData(new Pastries 
                { PastriesId = 1, Name = "Håndværker",
                  Price = 5M, ShortDescription = "NammeNam",
                  LongDescription = "Freshly baked with delicious crumb",
                  CategoryId = 1,
                  InStock = true, 
                  IsbackeryOfTheWeek = false 
                });

            modelBuilder.Entity<Pastries>().HasData(new Pastries 
                 { PastriesId = 2,
                   Name = "Smørkage", 
                   Price = 30M, 
                   ShortDescription = "Lots of butter", 
                   LongDescription = "o", 
                   CategoryId = 2,
                   InStock = true, 
                   IsbackeryOfTheWeek = false });

            modelBuilder.Entity<Pastries>().HasData(
                new Pastries { PastriesId = 3, Name = "Bryllupskage", Price = 25000M, ShortDescription = "I DO", LongDescription = "Wedding time :-)", CategoryId = 3, InStock = true, IsbackeryOfTheWeek = true });

            modelBuilder.Entity<Pastries>().HasData(
                new Pastries { PastriesId = 4, Name = "Baguette", Price = 20M, ShortDescription = "Long Bread", LongDescription = "Long bread from France - the true parisian feeling", CategoryId = 1, InStock = true, IsbackeryOfTheWeek = true });

        }

    }
}
