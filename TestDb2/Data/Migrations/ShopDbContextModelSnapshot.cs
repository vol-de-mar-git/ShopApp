﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestDb2.Database;

namespace TestDb2.Data.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    partial class ShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrandDesigner", b =>
                {
                    b.Property<Guid>("BrandsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DesignersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BrandsId", "DesignersId");

                    b.HasIndex("DesignersId");

                    b.ToTable("BrandDesigner");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TestDb2.Database.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a22853e7-a39c-4562-8817-e783346e21b7"),
                            Name = "Gucci"
                        },
                        new
                        {
                            Id = new Guid("d3cafb27-182b-4f93-a50c-7bb9a98b9e8e"),
                            Name = "H&M"
                        },
                        new
                        {
                            Id = new Guid("7ad5b333-21d7-4a44-8aa4-cea1a20193ca"),
                            Name = "Guess"
                        },
                        new
                        {
                            Id = new Guid("f7b3b55e-a41f-40a6-a37e-df4ebf3f8392"),
                            Name = "Zara"
                        });
                });

            modelBuilder.Entity("TestDb2.Database.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00ff0b00-d437-425a-987e-5c94c4b1f94e"),
                            Name = "OuterWear"
                        },
                        new
                        {
                            Id = new Guid("d80c1326-35ae-4a48-9fda-be98316eafc6"),
                            Name = "FootWear"
                        },
                        new
                        {
                            Id = new Guid("0010b59d-9342-4385-a6fa-361d7273d83c"),
                            Name = "Accessories"
                        });
                });

            modelBuilder.Entity("TestDb2.Database.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("84b7599a-6022-4c31-bec9-a50e94e30437"),
                            Name = "Russia"
                        },
                        new
                        {
                            Id = new Guid("7e2099c6-9bb8-42b9-a0a6-e5e01736f902"),
                            Name = "China"
                        },
                        new
                        {
                            Id = new Guid("c50e19e7-e416-44bf-806c-06b8e4bde5f0"),
                            Name = "USA"
                        },
                        new
                        {
                            Id = new Guid("0b7a5f8b-a7b7-42b3-b816-057070338096"),
                            Name = "England"
                        });
                });

            modelBuilder.Entity("TestDb2.Database.Designer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Designers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e987a612-92dc-477b-bcee-f02c36c7fc85"),
                            CountryId = new Guid("84b7599a-6022-4c31-bec9-a50e94e30437"),
                            LastName = "Pit",
                            Name = "Brad"
                        },
                        new
                        {
                            Id = new Guid("896c6495-626e-41f8-8d80-25c7526b4937"),
                            CountryId = new Guid("c50e19e7-e416-44bf-806c-06b8e4bde5f0"),
                            LastName = "Marley",
                            Name = "Bob"
                        });
                });

            modelBuilder.Entity("TestDb2.Database.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<Guid?>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DesignerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DesignerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("763366db-b2fe-4e75-af4f-aa5b99db94ac"),
                            BrandId = new Guid("a22853e7-a39c-4562-8817-e783346e21b7"),
                            CategoryId = new Guid("0010b59d-9342-4385-a6fa-361d7273d83c"),
                            Count = 10,
                            CountryId = new Guid("84b7599a-6022-4c31-bec9-a50e94e30437"),
                            DesignerId = new Guid("e987a612-92dc-477b-bcee-f02c36c7fc85"),
                            Name = "Super Bag",
                            Price = 99.989999999999995
                        },
                        new
                        {
                            Id = new Guid("7f6286ff-2b93-44fc-af86-d9455a14347c"),
                            BrandId = new Guid("d3cafb27-182b-4f93-a50c-7bb9a98b9e8e"),
                            CategoryId = new Guid("00ff0b00-d437-425a-987e-5c94c4b1f94e"),
                            Count = 45,
                            CountryId = new Guid("7e2099c6-9bb8-42b9-a0a6-e5e01736f902"),
                            DesignerId = new Guid("896c6495-626e-41f8-8d80-25c7526b4937"),
                            Name = "T-Shirt",
                            Price = 26.989999999999998
                        },
                        new
                        {
                            Id = new Guid("aa3ace08-f158-4ba8-8f39-f813f0dbc501"),
                            BrandId = new Guid("7ad5b333-21d7-4a44-8aa4-cea1a20193ca"),
                            CategoryId = new Guid("d80c1326-35ae-4a48-9fda-be98316eafc6"),
                            Count = 4,
                            CountryId = new Guid("0b7a5f8b-a7b7-42b3-b816-057070338096"),
                            DesignerId = new Guid("896c6495-626e-41f8-8d80-25c7526b4937"),
                            Name = "Shoes",
                            Price = 129.99000000000001
                        },
                        new
                        {
                            Id = new Guid("75d7f620-0492-4cbf-b650-4ee9563ba8f4"),
                            BrandId = new Guid("f7b3b55e-a41f-40a6-a37e-df4ebf3f8392"),
                            CategoryId = new Guid("0010b59d-9342-4385-a6fa-361d7273d83c"),
                            Count = 76,
                            CountryId = new Guid("c50e19e7-e416-44bf-806c-06b8e4bde5f0"),
                            DesignerId = new Guid("e987a612-92dc-477b-bcee-f02c36c7fc85"),
                            Name = "Hat",
                            Price = 35.5
                        });
                });

            modelBuilder.Entity("BrandDesigner", b =>
                {
                    b.HasOne("TestDb2.Database.Brand", null)
                        .WithMany()
                        .HasForeignKey("BrandsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestDb2.Database.Designer", null)
                        .WithMany()
                        .HasForeignKey("DesignersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("TestDb2.Database.Designer", b =>
                {
                    b.HasOne("TestDb2.Database.Country", "Country")
                        .WithMany("Designers")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("TestDb2.Database.Product", b =>
                {
                    b.HasOne("TestDb2.Database.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId");

                    b.HasOne("TestDb2.Database.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("TestDb2.Database.Country", "Country")
                        .WithMany("Products")
                        .HasForeignKey("CountryId");

                    b.HasOne("TestDb2.Database.Designer", "Designer")
                        .WithMany("Products")
                        .HasForeignKey("DesignerId");

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Country");

                    b.Navigation("Designer");
                });

            modelBuilder.Entity("TestDb2.Database.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("TestDb2.Database.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("TestDb2.Database.Country", b =>
                {
                    b.Navigation("Designers");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("TestDb2.Database.Designer", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
