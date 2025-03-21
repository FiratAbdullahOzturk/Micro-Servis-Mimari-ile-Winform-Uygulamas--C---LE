﻿// <auto-generated />
using GlosySoftwareCase.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GlosySoftwareCase.DataAccessLayer.Migrations
{
    [DbContext(typeof(GlosyContext))]
    [Migration("20240801090616_ProductInfo")]
    partial class ProductInfo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GlosySoftwareCase.EntityLayer.Concrete.ProductCPrice", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductCalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ProductCPrices");
                });

            modelBuilder.Entity("GlosySoftwareCase.EntityLayer.Concrete.ProductInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductAmount")
                        .HasColumnType("int");

                    b.Property<int>("ProductCPriceId")
                        .HasColumnType("int");

                    b.Property<string>("ProductDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductInfos");
                });

            modelBuilder.Entity("GlosySoftwareCase.EntityLayer.Concrete.ProductCPrice", b =>
                {
                    b.HasOne("GlosySoftwareCase.EntityLayer.Concrete.ProductInfo", "ProductInfo")
                        .WithOne("ProductCPrice")
                        .HasForeignKey("GlosySoftwareCase.EntityLayer.Concrete.ProductCPrice", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductInfo");
                });

            modelBuilder.Entity("GlosySoftwareCase.EntityLayer.Concrete.ProductInfo", b =>
                {
                    b.Navigation("ProductCPrice")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
