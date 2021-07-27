﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotGrocy.Models;

namespace not_grocy_server_asp_net.Migrations
{
    [DbContext(typeof(StockContext))]
    partial class StockContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("StockApi.Models.StockItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("BestBeforeDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("best_before_date");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("INTEGER")
                        .HasColumnName("open");

                    b.Property<long?>("LocationId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("location_id");

                    b.Property<DateTime?>("OpenedDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("opened_date");

                    b.Property<double?>("Price")
                        .HasColumnType("REAL");

                    b.Property<long>("ProductId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("product_id");

                    b.Property<DateTime?>("PurchasedDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("purchased_date");

                    b.Property<DateTime?>("RowCreated")
                        .HasColumnType("TEXT")
                        .HasColumnName("row_created_timestamp");

                    b.Property<long?>("ShoppingLocationId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("shopping_location_id");

                    b.Property<string>("StockId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("stock_id");

                    b.HasKey("Id");

                    b.ToTable("stock");
                });
#pragma warning restore 612, 618
        }
    }
}
