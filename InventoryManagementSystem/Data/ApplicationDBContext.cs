using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Data
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = DESKTOP-605N226\\SQLEXPRESS ; initial catalog = InventoryMangaement ; integrated security = true ; TrustServerCertificate=True;");
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInWarehouse> productInWarehouses { get; set; }
        public DbSet<SupplyPermit> SupplyPermits { get; set; }
        public DbSet<SupplyPermitProduct> supplyPermitProducts { get; set; }
        public DbSet<TransferPermit> TransferPermits { get; set; }
        public DbSet<TransferPermitProduct> transferPermitProducts { get; set; }
        public DbSet<WithdrawPermit> WithdrawPermits { get; set; }
        public DbSet<WithdrawPermitProduct> WithdrawPermitProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Supply Permit Products keys
            modelBuilder.Entity<SupplyPermitProduct>()
                .HasKey(sp => new { sp.SupplyPermitId, sp.ProductId });

            modelBuilder.Entity<SupplyPermitProduct>()
                .HasOne(sp => sp.SupplyPermit)
                .WithMany(p => p.Products)
                .HasForeignKey(sp => sp.SupplyPermitId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SupplyPermitProduct>()
                .HasOne(sp => sp.Product)
                .WithMany()
                .HasForeignKey(sp => sp.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Withdraw Permit Products keys
            modelBuilder.Entity<WithdrawPermitProduct>()
                .HasKey(sp => new { sp.WithdrawPermitId, sp.StockID });

            modelBuilder.Entity<WithdrawPermitProduct>()
                .HasOne(sp => sp.WithdrawPermit)
                .WithMany(p => p.Products)
                .HasForeignKey(sp => sp.WithdrawPermitId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<WithdrawPermitProduct>()
                .HasOne(sp => sp.Product)
                .WithMany()
                .HasForeignKey(sp => sp.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<WithdrawPermitProduct>()
                .HasOne(sp => sp.Stock)
                .WithMany()
                .HasForeignKey(sp => sp.StockID)
                .OnDelete(DeleteBehavior.Restrict);

            // Transfer Permit Products keys
            modelBuilder.Entity<TransferPermitProduct>()
                .HasKey(sp => new { sp.TransferPermitId, sp.StockID });

            modelBuilder.Entity<TransferPermitProduct>()
                .HasOne(sp => sp.TransferPermit)
                .WithMany(p => p.Products)
                .HasForeignKey(sp => sp.TransferPermitId)
                .OnDelete(DeleteBehavior.Cascade); // keep cascade here

            modelBuilder.Entity<TransferPermitProduct>()
                .HasOne(sp => sp.Product)
                .WithMany()
                .HasForeignKey(sp => sp.ProductId)
                .OnDelete(DeleteBehavior.Restrict); // restrict to avoid multiple cascade paths

            modelBuilder.Entity<TransferPermitProduct>()
                .HasOne(sp => sp.Stock)
                .WithMany()
                .HasForeignKey(sp => sp.StockID)
                .OnDelete(DeleteBehavior.Restrict); // restrict to avoid multiple cascade paths

            modelBuilder.Entity<TransferPermit>()
                .HasOne(tp => tp.SourceWarehouse)
                .WithMany()
                .HasForeignKey(tp => tp.SourceWarehouseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransferPermit>()
                .HasOne(tp => tp.DestinationWarehouse)
                .WithMany()
                .HasForeignKey(tp => tp.DestinationWarehouseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
