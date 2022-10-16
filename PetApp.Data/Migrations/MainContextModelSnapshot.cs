﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetApp.Data.Concrete.EfCore;

namespace PetApp.Data.Migrations
{
    [DbContext(typeof(MainContext))]
    partial class MainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("PetApp.Entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HotelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.HasIndex("HotelId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("PetApp.Entity.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FavouriteHotelHotelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.HasIndex("FavouriteHotelHotelId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("PetApp.Entity.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("NightlyPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("HotelId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("PetApp.Entity.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OwnerCustomerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PetId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OwnerCustomerId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("PetApp.Entity.PetCategory", b =>
                {
                    b.Property<int>("PetId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PetId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("PetCategory");
                });

            modelBuilder.Entity("PetApp.Entity.Category", b =>
                {
                    b.HasOne("PetApp.Entity.Hotel", null)
                        .WithMany("Categories")
                        .HasForeignKey("HotelId");
                });

            modelBuilder.Entity("PetApp.Entity.Customer", b =>
                {
                    b.HasOne("PetApp.Entity.Hotel", "FavouriteHotel")
                        .WithMany()
                        .HasForeignKey("FavouriteHotelHotelId");
                });

            modelBuilder.Entity("PetApp.Entity.Pet", b =>
                {
                    b.HasOne("PetApp.Entity.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("PetApp.Entity.Customer", "Owner")
                        .WithMany("Pets")
                        .HasForeignKey("OwnerCustomerId");
                });

            modelBuilder.Entity("PetApp.Entity.PetCategory", b =>
                {
                    b.HasOne("PetApp.Entity.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetApp.Entity.Hotel", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
