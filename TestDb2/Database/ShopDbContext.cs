using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestDb2.Database
{
    public class ShopDbContext : IdentityDbContext<IdentityUser>
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; } 
        
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Designer> Designers { get; set; }
        
        public DbSet<Category> Categories { get; set; }
        
        
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Country>().HasData(GetCountries());

            builder.Entity<Brand>().HasData(GetBrands());
            
            builder.Entity<Category>().HasData(GetCategories());

            builder.Entity<Designer>().HasData(GetDesigners());

            builder.Entity<Product>().HasData(GetProducts());

        }

        private List<Country> GetCountries()
        {
            return new List<Country>()
            {
                new Country {Id = Guid.Parse("84b7599a-6022-4c31-bec9-a50e94e30437"), Name = "Russia"},
                new Country {Id = Guid.Parse("7e2099c6-9bb8-42b9-a0a6-e5e01736f902"), Name = "China"},
                new Country {Id = Guid.Parse("c50e19e7-e416-44bf-806c-06b8e4bde5f0"), Name = "USA"},
                new Country {Id = Guid.Parse("0b7a5f8b-a7b7-42b3-b816-057070338096"), Name = "England"}
            };
        }

        private List<Brand> GetBrands()
        {
            return new List<Brand>()
            {
                new Brand {Id = Guid.Parse("a22853e7-a39c-4562-8817-e783346e21b7"), Name = "Gucci"},
                new Brand {Id = Guid.Parse("d3cafb27-182b-4f93-a50c-7bb9a98b9e8e"), Name = "H&M"},
                new Brand {Id = Guid.Parse("7ad5b333-21d7-4a44-8aa4-cea1a20193ca"), Name = "Guess"},
                new Brand {Id = Guid.Parse("f7b3b55e-a41f-40a6-a37e-df4ebf3f8392"), Name = "Zara"}
            };
        }

        private List<Category> GetCategories()
        {
            return new List<Category>()
            {
                new Category {Id = Guid.Parse("00ff0b00-d437-425a-987e-5c94c4b1f94e"), Name = "OuterWear"},
                new Category {Id = Guid.Parse("d80c1326-35ae-4a48-9fda-be98316eafc6"), Name = "FootWear"},
                new Category {Id = Guid.Parse("0010b59d-9342-4385-a6fa-361d7273d83c"), Name = "Accessories"}
            };
        }

        private List<Designer> GetDesigners()
        {
            return new List<Designer>()
            {
                new Designer {Id = Guid.Parse("e987a612-92dc-477b-bcee-f02c36c7fc85"), Name = "Brad", LastName = "Pit",CountryId = Guid.Parse("84b7599a-6022-4c31-bec9-a50e94e30437")},
                new Designer {Id = Guid.Parse("896c6495-626e-41f8-8d80-25c7526b4937"), Name = "Bob", LastName = "Marley",CountryId = Guid.Parse("c50e19e7-e416-44bf-806c-06b8e4bde5f0")}
            };
        }

        private List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = Guid.NewGuid(), Name = "Super Bag",
                    BrandId = Guid.Parse("a22853e7-a39c-4562-8817-e783346e21b7"),
                    CategoryId = Guid.Parse("0010b59d-9342-4385-a6fa-361d7273d83c"),
                    CountryId = Guid.Parse("84b7599a-6022-4c31-bec9-a50e94e30437"),
                    DesignerId = Guid.Parse("e987a612-92dc-477b-bcee-f02c36c7fc85"), Count = 10, Price = 99.99
                },
                new Product()
                {
                    Id = Guid.NewGuid(), Name = "T-Shirt",
                    BrandId = Guid.Parse("d3cafb27-182b-4f93-a50c-7bb9a98b9e8e"),
                    CategoryId = Guid.Parse("00ff0b00-d437-425a-987e-5c94c4b1f94e"),
                    CountryId = Guid.Parse("7e2099c6-9bb8-42b9-a0a6-e5e01736f902"),
                    DesignerId = Guid.Parse("896c6495-626e-41f8-8d80-25c7526b4937"), Count = 45, Price = 26.99
                },
                new Product()
                {
                    Id = Guid.NewGuid(), Name = "Shoes",
                    BrandId = Guid.Parse("7ad5b333-21d7-4a44-8aa4-cea1a20193ca"),
                    CategoryId = Guid.Parse("d80c1326-35ae-4a48-9fda-be98316eafc6"),
                    CountryId = Guid.Parse("0b7a5f8b-a7b7-42b3-b816-057070338096"),
                    DesignerId = Guid.Parse("896c6495-626e-41f8-8d80-25c7526b4937"), Count = 4, Price = 129.99
                },
                new Product()
                {
                    Id = Guid.NewGuid(), Name = "Hat",
                    BrandId = Guid.Parse("f7b3b55e-a41f-40a6-a37e-df4ebf3f8392"),
                    CategoryId = Guid.Parse("0010b59d-9342-4385-a6fa-361d7273d83c"),
                    CountryId = Guid.Parse("c50e19e7-e416-44bf-806c-06b8e4bde5f0"),
                    DesignerId = Guid.Parse("e987a612-92dc-477b-bcee-f02c36c7fc85"), Count = 76, Price = 35.50
                }
            };
        }
    }
}