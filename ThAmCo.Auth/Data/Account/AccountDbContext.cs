using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ThAmCo.Auth.Data.Account
{
    public class AccountDbContext : IdentityDbContext<AppUser>
    {
        public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("account");

            builder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Name = "Manager",
                    NormalizedName = "Manager",
                    Descriptor = "ThAmCo Manager"
                },
                new AppRole
                {
                    Name = "Staff",
                    NormalizedName = "STAFF",
                    Descriptor = "ThAmCo Staff Members"
                },
                new AppRole
                {
                    Name = "Customer",
                    NormalizedName = "CUSTOMER",
                    Descriptor = "ThAmCo Customers"
                }
            );
        }
    }
}
