﻿using Microsoft.EntityFrameworkCore;

namespace curdcoreEx.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt):base(opt) { }
        protected override void OnModelCreating (ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Electronics" },
                new Category { CategoryID = 2, CategoryName = "Cloths" },
                new Category { CategoryID = 3, CategoryName = "Computer" }
                );
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}