using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminAPI.Models.DBContext
{

    public class AlleShopDBContext : DbContext
    {

        public DbSet<AboutUs> AboutUs { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Discount> Discounts { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<ImportLog> ImportLogs { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Orderdetail> Orderdetails { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Product_Detail> Product_Details { get; set; }

        public DbSet<Product_Image> Product_Images { get; set; }

        public DbSet<Type> Types { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<VIP> VIPS { get; set; 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=AlleShop;User ID=sa;Password=123456");
        }
    }

}
