using Core;
using Microsoft.EntityFrameworkCore;

namespace Entity
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt) { }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Admin>().HasData(
                new Admin() { AdminID=1,FirstName="Manoj",LastName="Patil",EmailID="manoj@hotmail.com",Password="abcd"}
                );

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}