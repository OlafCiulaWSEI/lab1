﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("WebApplication1.Models.ContactEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Category = 0,
                            Created = new DateTime(2024, 11, 18, 16, 30, 25, 56, DateTimeKind.Local).AddTicks(335),
                            Email = "adam@.wsei.edu.pl",
                            FirstName = "Adam",
                            LastName = "Nowak",
                            OrganizationId = 1,
                            PhoneNumber = "333 333 333"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2000, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Category = 0,
                            Created = new DateTime(2024, 11, 18, 16, 30, 25, 56, DateTimeKind.Local).AddTicks(378),
                            Email = "ada@.wsei.edu.pl",
                            FirstName = "Ada",
                            LastName = "Fisak",
                            OrganizationId = 2,
                            PhoneNumber = "333 333 333"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.OrganizationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Regon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("organizations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "WSEI",
                            Nip = "12423534",
                            Regon = "74576364"
                        },
                        new
                        {
                            Id = 2,
                            Name = "WEBCON",
                            Nip = "864363",
                            Regon = "7254231"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.ContactEntity", b =>
                {
                    b.HasOne("WebApplication1.Models.OrganizationEntity", "Organization")
                        .WithMany("Contacts")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("WebApplication1.Models.OrganizationEntity", b =>
                {
                    b.OwnsOne("WebApplication1.Models.Address", "Address", b1 =>
                        {
                            b1.Property<int>("OrganizationEntityId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("OrganizationEntityId");

                            b1.ToTable("organizations");

                            b1.WithOwner()
                                .HasForeignKey("OrganizationEntityId");

                            b1.HasData(
                                new
                                {
                                    OrganizationEntityId = 1,
                                    City = "Kraków",
                                    Street = "św Filipa 18"
                                },
                                new
                                {
                                    OrganizationEntityId = 2,
                                    City = "Kraków",
                                    Street = "Buncha"
                                });
                        });

                    b.Navigation("Address");
                });

            modelBuilder.Entity("WebApplication1.Models.OrganizationEntity", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
