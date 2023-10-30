using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Ehou_TekShop.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Image> Images { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<PurchaseProduct> PurchaseProducts { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    }
}