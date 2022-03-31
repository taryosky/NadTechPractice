﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NadTechPractice.Data;

namespace NadTechPractice.Data.Migrations
{
    [DbContext(typeof(NadTechPracticeContext))]
    partial class NadTechPracticeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("NadTechPractice.Entities.Models.Address", b =>
                {
                    b.Property<long>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AddressId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            AddressId = 1L,
                            CustomerId = 1L,
                            DateCreated = new DateTime(2022, 3, 31, 20, 54, 38, 941, DateTimeKind.Local).AddTicks(6691),
                            HouseNumber = 5,
                            PostCode = "1100021",
                            Street = "Ajasalane"
                        });
                });

            modelBuilder.Entity("NadTechPractice.Entities.Models.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Age")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1L,
                            Age = new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateCreated = new DateTime(2022, 3, 31, 20, 54, 38, 904, DateTimeKind.Local).AddTicks(5899),
                            Gender = 0,
                            Name = "Clement Azibataram"
                        });
                });

            modelBuilder.Entity("NadTechPractice.Entities.Models.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<long>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Amount = 593.89m,
                            CustomerId = 1L,
                            DateCreated = new DateTime(2022, 3, 31, 20, 54, 38, 944, DateTimeKind.Local).AddTicks(1288)
                        },
                        new
                        {
                            OrderId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Amount = 983.90m,
                            CustomerId = 1L,
                            DateCreated = new DateTime(2022, 3, 31, 20, 54, 38, 944, DateTimeKind.Local).AddTicks(4000)
                        });
                });

            modelBuilder.Entity("NadTechPractice.Entities.Models.Address", b =>
                {
                    b.HasOne("NadTechPractice.Entities.Models.Customer", "Customer")
                        .WithMany("Address")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("NadTechPractice.Entities.Models.Order", b =>
                {
                    b.HasOne("NadTechPractice.Entities.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("NadTechPractice.Entities.Models.Customer", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
