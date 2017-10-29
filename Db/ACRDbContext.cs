using System;
using Microsoft.EntityFrameworkCore;
using Db.DataModels;

namespace Db
{
    public class ACRDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Week> Week { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Holiday> Holiday { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Benefit> Benefit { get; set; }

        public ACRDbContext(DbContextOptions<ACRDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Remove pluralizing
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<School>().ToTable("School");
            modelBuilder.Entity<Week>().ToTable("Week");
            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<Holiday>().ToTable("Holiday");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Benefit>().ToTable("Benefit");
        }
    }
}