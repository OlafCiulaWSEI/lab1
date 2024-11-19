﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241119111616_Identity")]
    partial class Identity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "7218b28f-5023-4a90-975b-51cf156ba5b3",
                            ConcurrencyStamp = "7218b28f-5023-4a90-975b-51cf156ba5b3",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "eecd0447-019d-4fa5-aeae-8b3b3ed150be",
                            ConcurrencyStamp = "eecd0447-019d-4fa5-aeae-8b3b3ed150be",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "7218b28f-5023-4a90-975b-51cf156ba5b3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a1eece8b-f1b7-4886-b174-08c5d8202904",
                            Email = "olaf@wsei.edu.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "OLAF@WSEI.EDU.PL",
                            NormalizedUserName = "OLAF",
                            PasswordHash = "AQAAAAIAAYagAAAAEIcHqxEmz11qd8Xb7rMXUCaBS0Gd4AdvgdsClcKe+X0aDJk4PBPEypO7OsffswHigw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4d567b81-39ed-4198-80e5-d3373d7efebc",
                            TwoFactorEnabled = false,
                            UserName = "Olaf"
                        },
                        new
                        {
                            Id = "eecd0447-019d-4fa5-aeae-8b3b3ed150be",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5499b2b5-755b-40f1-b35b-130b3148b829",
                            Email = "kuba@wsei.edu.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "KUBA@WSEI.EDU.PL",
                            NormalizedUserName = "KUBA",
                            PasswordHash = "AQAAAAIAAYagAAAAELzKRIaZTKr58OszsZ28Gfl1FeztCLzhFekkfBy2zimWaSvJYIcK0MAwegFVPntLMA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ae2d2ff2-6cba-48e2-93f8-4ad1ffd929fa",
                            TwoFactorEnabled = false,
                            UserName = "Kuba"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "7218b28f-5023-4a90-975b-51cf156ba5b3",
                            RoleId = "7218b28f-5023-4a90-975b-51cf156ba5b3"
                        },
                        new
                        {
                            UserId = "eecd0447-019d-4fa5-aeae-8b3b3ed150be",
                            RoleId = "eecd0447-019d-4fa5-aeae-8b3b3ed150be"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

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
                            Created = new DateTime(2024, 11, 19, 12, 16, 13, 330, DateTimeKind.Local).AddTicks(6145),
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
                            Created = new DateTime(2024, 11, 19, 12, 16, 13, 330, DateTimeKind.Local).AddTicks(6235),
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
