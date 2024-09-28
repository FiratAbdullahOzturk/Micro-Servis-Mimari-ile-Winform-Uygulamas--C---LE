using GlosySoftwareCase.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlosySoftwareCase.DataAccessLayer.Context
{
    public class GlosyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress; initial Catalog=GlosySoftwareCaseDb; TrustServerCertificate=True; integrated Security= true") ;
        }
        //public DbSet<Product> Products { get; set; }
        public DbSet<ProductInfo> ProductInfos { get; set; }
        public DbSet<ProductCPrice> ProductCPrices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ProductInfo ve ProductCPrice arasındaki ilişkileri tanımlıyoruz
            modelBuilder.Entity<ProductInfo>()
                .HasOne(p => p.ProductCPrice)
                .WithOne(pc => pc.ProductInfo)
                .HasForeignKey<ProductCPrice>(pc => pc.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
