using System;
using Microsoft.EntityFrameworkCore;
using Db.DataModels;

namespace Db
{
    public class ACRDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<School> School { get; set; }

        public ACRDbContext(DbContextOptions<ACRDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Remove pluralizing
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<School>().ToTable("School");
        }
    }
}