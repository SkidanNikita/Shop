using Microsoft.EntityFrameworkCore;
using OnlineShopWPF.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopWPF.Context
{
    public class Context : DbContext
    {
        public DbSet<ORD> ORDs { get; set; }
        public DbSet<Power_Supply> Power_Supplys { get; set; }
        public DbSet<SSD> SSDs { get; set; }

        public Context()
        {
            Database.EnsureCreated();
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=1-PC\SQLEXPRESS;Database=OnlineShopWPF;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ORD>()
                        .ToTable("ORDs");
            modelBuilder.Entity<Power_Supply>()
                .ToTable("Power_Supplys");
            modelBuilder.Entity<SSD>()
                        .ToTable("SSDs");
            base.OnModelCreating(modelBuilder);
        }
    }
}

