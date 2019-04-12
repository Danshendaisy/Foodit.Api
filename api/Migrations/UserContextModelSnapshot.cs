﻿// <auto-generated />
using System;
using Foodit.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Foodit.Api.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Foodit.Api.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BuyerName");

                    b.Property<string>("ItemDescription");

                    b.Property<int>("ItemHighestBid");

                    b.Property<int>("ItemSoldPrice");

                    b.Property<string>("SellerName");

                    b.Property<string>("TransactionId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TransactionId");

                    b.HasIndex("UserId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Foodit.Api.Models.Transaction", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BuyerUserId");

                    b.Property<string>("SellerUserId");

                    b.Property<int>("TransAmount");

                    b.Property<DateTime>("TransDate");

                    b.Property<string>("TransItemId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Foodit.Api.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserAddress");

                    b.Property<string>("UserEmail");

                    b.Property<int>("UserFooditCoins");

                    b.Property<string>("UserName");

                    b.Property<string>("UserPassword");

                    b.Property<int>("UserPhoneNumber");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Foodit.Api.Models.Item", b =>
                {
                    b.HasOne("Foodit.Api.Models.Transaction")
                        .WithMany("UserItems")
                        .HasForeignKey("TransactionId");

                    b.HasOne("Foodit.Api.Models.User")
                        .WithMany("UserItems")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Foodit.Api.Models.Transaction", b =>
                {
                    b.HasOne("Foodit.Api.Models.User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
