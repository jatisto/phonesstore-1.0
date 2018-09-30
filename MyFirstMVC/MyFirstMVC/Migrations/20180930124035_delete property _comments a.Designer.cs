﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFirstMVC.Models;

namespace MyFirstMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180930124035_delete property _comments a")]
    partial class deleteproperty_commentsa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyFirstMVC.Controllers.RatingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("RatingModelsDB");
                });

            modelBuilder.Entity("MyFirstMVC.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("ParentCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Name = "iOS" },
                        new { Id = 2, Name = "Android OS" },
                        new { Id = 3, Name = "BlackBerry OS" }
                    );
                });

            modelBuilder.Entity("MyFirstMVC.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<int?>("_CompanyId");

                    b.Property<DateTime>("_dataCreateCompany");

                    b.Property<string>("_emailCompany");

                    b.Property<string>("_mode");

                    b.HasKey("Id");

                    b.HasIndex("_CompanyId");

                    b.ToTable("Companies");

                    b.HasData(
                        new { Id = 1, Name = "Apple", _dataCreateCompany = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), _emailCompany = "support.apple@apple.com" },
                        new { Id = 2, Name = "Samsung", _dataCreateCompany = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), _emailCompany = "support.apple@apple.com" },
                        new { Id = 3, Name = "Nokia", _dataCreateCompany = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 4, Name = "Xiaomi", _dataCreateCompany = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 5, Name = "LG", _dataCreateCompany = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 6, Name = "Huawei", _dataCreateCompany = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 7, Name = "Sony", _dataCreateCompany = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 8, Name = "BlackBerry", _dataCreateCompany = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 9, Name = "Philips", _dataCreateCompany = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                    );
                });

            modelBuilder.Entity("MyFirstMVC.Models.ExchangeRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("_currencyCode");

                    b.Property<string>("_currencyName");

                    b.Property<double>("_currencyRate");

                    b.HasKey("Id");

                    b.ToTable("ExchangeRates");

                    b.HasData(
                        new { Id = 1, _currencyCode = "RUB", _currencyName = "Рубль", _currencyRate = 57.0 },
                        new { Id = 2, _currencyCode = "KGS", _currencyName = "Сом", _currencyRate = 68.0 },
                        new { Id = 3, _currencyCode = "EUR", _currencyName = "Евро", _currencyRate = 80.99 }
                    );
                });

            modelBuilder.Entity("MyFirstMVC.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addres");

                    b.Property<string>("ContactPhone");

                    b.Property<int>("PhoneId");

                    b.Property<string>("User");

                    b.HasKey("Id");

                    b.HasIndex("PhoneId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MyFirstMVC.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int>("CompanyId");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Phones");

                    b.HasData(
                        new { Id = 1, CategoryId = 1, CompanyId = 1, Name = "Apple iPhone 7 256Gb Red", Price = 74400.0, Quantity = 15 },
                        new { Id = 2, CategoryId = 1, CompanyId = 1, Name = "Apple iPhone 6S (Space Grey, 32GB)", Price = 30500.0, Quantity = 10 },
                        new { Id = 3, CategoryId = 1, CompanyId = 1, Name = "Apple iPhone X (Space Grey, 256GB)", Price = 99999.0, Quantity = 25 },
                        new { Id = 4, CategoryId = 2, CompanyId = 2, Name = "Samsung On7 Pro (Gold)", Price = 7990.0, Quantity = 0 },
                        new { Id = 5, CategoryId = 2, CompanyId = 2, Name = "Samsung Galaxy On7 Prime (Gold, 4GB RAM + 64GB Memory)", Price = 13990.0, Quantity = 0 },
                        new { Id = 6, CategoryId = 2, CompanyId = 4, Name = "Redmi 6 Pro (Black, 32GB)", Price = 11499.0, Quantity = 13 },
                        new { Id = 7, CategoryId = 2, CompanyId = 4, Name = "Redmi Y2 (Rose Gold, 32GB)", Price = 9999.0, Quantity = 0 },
                        new { Id = 8, CategoryId = 2, CompanyId = 5, Name = "LG Q6 (Black, 18:9 FullVision Display)", Price = 11820.0, Quantity = 10 },
                        new { Id = 9, CategoryId = 2, CompanyId = 5, Name = "LG V30+ (18:9 OLED FullVisionTM, 128GB, Black)", Price = 34963.0, Quantity = 5 },
                        new { Id = 10, CategoryId = 3, CompanyId = 8, Name = "BlackBerry Passport 32GB (White)", Price = 26999.0, Quantity = 3 },
                        new { Id = 11, CategoryId = 2, CompanyId = 6, Name = "Huawei P20 Pro Blue (40MP Leica Triple Camera, 6GB+128GB)", Price = 64999.0, Quantity = 11 },
                        new { Id = 12, CategoryId = 2, CompanyId = 3, Name = "Nokia 6.1 (2018) (4GB + 64GB, Blue-Gold)", Price = 15950.0, Quantity = 14 },
                        new { Id = 13, CategoryId = 2, CompanyId = 7, Name = "Sony Xperia R1 Plus Dual SIM (Black)", Price = 11899.0, Quantity = 0 }
                    );
                });

            modelBuilder.Entity("MyFirstMVC.Models.PhoneOnStock", b =>
                {
                    b.Property<int>("PhoneId");

                    b.Property<int>("StockId");

                    b.Property<int>("Quantity");

                    b.HasKey("PhoneId", "StockId");

                    b.HasIndex("StockId");

                    b.ToTable("PhonesOnStocks");

                    b.HasData(
                        new { PhoneId = 1, StockId = 2, Quantity = 15 },
                        new { PhoneId = 3, StockId = 1, Quantity = 25 },
                        new { PhoneId = 4, StockId = 3, Quantity = 0 },
                        new { PhoneId = 7, StockId = 2, Quantity = 40 },
                        new { PhoneId = 6, StockId = 1, Quantity = 33 },
                        new { PhoneId = 5, StockId = 3, Quantity = 55 },
                        new { PhoneId = 2, StockId = 2, Quantity = 75 },
                        new { PhoneId = 9, StockId = 1, Quantity = 25 },
                        new { PhoneId = 8, StockId = 3, Quantity = 30 },
                        new { PhoneId = 10, StockId = 3, Quantity = 7 },
                        new { PhoneId = 12, StockId = 2, Quantity = 24 }
                    );
                });

            modelBuilder.Entity("MyFirstMVC.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Stocks");

                    b.HasData(
                        new { Id = 1, Name = "Склад 1" },
                        new { Id = 2, Name = "Склад 2" },
                        new { Id = 3, Name = "Склад 3" }
                    );
                });

            modelBuilder.Entity("MyFirstMVC.Models.Category", b =>
                {
                    b.HasOne("MyFirstMVC.Models.Category", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyFirstMVC.Models.Company", b =>
                {
                    b.HasOne("MyFirstMVC.Models.Company", "_Company")
                        .WithMany("CompaniesEnumerable")
                        .HasForeignKey("_CompanyId");
                });

            modelBuilder.Entity("MyFirstMVC.Models.Order", b =>
                {
                    b.HasOne("MyFirstMVC.Models.Phone", "Phone")
                        .WithMany("Orders")
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyFirstMVC.Models.Phone", b =>
                {
                    b.HasOne("MyFirstMVC.Models.Category", "Category")
                        .WithMany("Phones")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MyFirstMVC.Models.Company", "Company")
                        .WithMany("Phones")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyFirstMVC.Models.PhoneOnStock", b =>
                {
                    b.HasOne("MyFirstMVC.Models.Phone", "Phone")
                        .WithMany("PhoneOnStocks")
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyFirstMVC.Models.Stock", "Stock")
                        .WithMany("PhoneOnStocks")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
