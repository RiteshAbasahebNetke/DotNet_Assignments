﻿using Microsoft.EntityFrameworkCore;

namespace CURDUsing6._0.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Dept>().HasData(
                new Dept() { DeptID=1,DeptName="IT"},
                new Dept() { DeptID=2,DeptName="Sales"},
                new Dept() { DeptID=3,DeptName="Purchase"}
                );
        }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Emp> Emps { get; set; }
    }
}