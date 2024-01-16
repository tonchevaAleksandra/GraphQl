﻿using GraphqlProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphqlProject.Data
{
    public class GraphQLDbContext : DbContext
    {
        public GraphQLDbContext(DbContextOptions<GraphQLDbContext> options) : base(options) { }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
              new Category { Id = 1, Name = "Appetizers", ImageUrl = "https://example.com/categories/appetizers.jpg" },
              new Category { Id = 2, Name = "Main Course", ImageUrl = "https://example.com/categories/main-course.jpg" },
              new Category { Id = 3, Name = "Desserts", ImageUrl = "https://example.com/categories/desserts.jpg" }
           );

            modelBuilder.Entity<Menu>().HasData(
               new Menu { Id = 1, Name = "Chicken Wings", Description = "Spicy chicken wings served with blue cheese dip.", Price = 9.99M, ImageUrl = "https://example.com/menus/chicken-wings.jpg", CategoryId = 1 },
               new Menu { Id = 2, Name = "Steak", Description = "Grilled steak with mashed potatoes and vegetables.", Price = 24.50M, ImageUrl = "https://example.com/menus/steak.jpg", CategoryId = 2 },
               new Menu { Id = 3, Name = "Chocolate Cake", Description = "Decadent chocolate cake with a scoop of vanilla ice cream.", Price = 6.95M, ImageUrl = "https://example.com/menus/chocolate-cake.jpg", CategoryId = 3 }
            );

            modelBuilder.Entity<Reservation>().HasData(
               new Reservation { Id = 1, CustomerName = "John Doe", Email = "johndoe@example.com", PhoneNumber = "555-123-4567", PartySize = 2, SpecialRequest = "No nuts in the dishes, please.", ReservationDate = DateTime.Now.AddDays(7) },
               new Reservation { Id = 2, CustomerName = "Jane Smith", Email = "janesmith@example.com", PhoneNumber = "555-987-6543", PartySize = 4, SpecialRequest = "Gluten-free options required.", ReservationDate = DateTime.Now.AddDays(10) },
               new Reservation { Id = 3, CustomerName = "Michael Johnson", Email = "michaeljohnson@example.com", PhoneNumber = "555-789-0123", PartySize = 6, SpecialRequest = "Celebrating a birthday.", ReservationDate = DateTime.Now.AddDays(14) }
           );
        }
    }
}
