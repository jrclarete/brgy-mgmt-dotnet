﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using brgy_mgmt_dotnet.identity.Contexts;

#nullable disable

namespace brgy_mgmt_dotnet.identity.Migrations
{
    [DbContext(typeof(BrgyIdentityDbContext))]
    partial class BrgyIdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("brgy_mgmt_dotnet.identity.Models.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47"),
                            Description = "Administrator",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556"),
                            Description = "Main_Official",
                            Name = "Main_Official",
                            NormalizedName = "MAIN_OFFICIAL"
                        },
                        new
                        {
                            Id = new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4"),
                            Description = "SK_Official",
                            Name = "SK_Official",
                            NormalizedName = "SK_OFFICIAL"
                        });
                });

            modelBuilder.Entity("brgy_mgmt_dotnet.identity.Models.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "HOUSEHOLD",
                            ClaimValue = "[\"CREATE\",\"READ\",\"UPDATE\",\"DELETE\"]",
                            RoleId = new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47")
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "HOUSEHOLD",
                            ClaimValue = "[\"CREATE\",\"READ\",\"UPDATE\",\"DELETE\"]",
                            RoleId = new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556")
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "HOUSEHOLD",
                            ClaimValue = "[\"READ\"]",
                            RoleId = new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4")
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "BRGY_INFO",
                            ClaimValue = "[\"CREATE\",\"READ\",\"UPDATE\",\"DELETE\"]",
                            RoleId = new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47")
                        });
                });

            modelBuilder.Entity("brgy_mgmt_dotnet.identity.Models.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomUsername")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("ExternalUserId")
                        .HasColumnType("int");

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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a16a4d4b-e3a1-45b9-94de-f91f33581181",
                            CustomUsername = "admin",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJr78BiZL3Vhd8dIJuZ23a2UGxGhwav6RKcgirSe706N0uC1SxabsZGUN6MTqyxCow==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        },
                        new
                        {
                            Id = new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "31e99ff7-01d8-4dc5-8bf8-e17d247744fc",
                            CustomUsername = "ggn",
                            Email = "garyn.green@localhost.com",
                            EmailConfirmed = true,
                            ExternalUserId = 1,
                            LockoutEnabled = false,
                            NormalizedEmail = "GARYN.GREEN@LOCALHOST.COM",
                            NormalizedUserName = "GARYN.GREEN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEP7lBYWgvQNpu2QgU7IUepcQnGQho/1T4UyNvt3kaWyhPalDA24q4TgK48bbPKpSPA==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "garyn.green@localhost.com"
                        },
                        new
                        {
                            Id = new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c1da121e-e060-4983-ab50-0ecba76fa62c",
                            CustomUsername = "jss",
                            Email = "jamesina.sanders@localhost.com",
                            EmailConfirmed = true,
                            ExternalUserId = 2,
                            LockoutEnabled = false,
                            NormalizedEmail = "JAMESINA.SANDERS@LOCALHOST.COM",
                            NormalizedUserName = "JAMESINA.SANDERS@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEA8CRR44N337JXqT7gDp3+UxZcx2MvYrBkIKY+UFmBBqJrcxsrcfN/Vb7mf7zgu6NA==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "jamesina.sanders@localhost.com"
                        });
                });

            modelBuilder.Entity("brgy_mgmt_dotnet.identity.Models.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("brgy_mgmt_dotnet.identity.Models.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                            RoleId = new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47")
                        },
                        new
                        {
                            UserId = new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19"),
                            RoleId = new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556")
                        },
                        new
                        {
                            UserId = new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a"),
                            RoleId = new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("brgy_mgmt_dotnet.identity.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("brgy_mgmt_dotnet.identity.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("brgy_mgmt_dotnet.identity.Models.AppRoleClaim", b =>
                {
                    b.HasOne("brgy_mgmt_dotnet.identity.Models.AppRole", "AppRole")
                        .WithMany("AppRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");
                });

            modelBuilder.Entity("brgy_mgmt_dotnet.identity.Models.AppUserClaim", b =>
                {
                    b.HasOne("brgy_mgmt_dotnet.identity.Models.AppUser", "AppUser")
                        .WithMany("AppUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("brgy_mgmt_dotnet.identity.Models.AppUserRole", b =>
                {
                    b.HasOne("brgy_mgmt_dotnet.identity.Models.AppRole", "AppRole")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("brgy_mgmt_dotnet.identity.Models.AppUser", "AppUser")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("brgy_mgmt_dotnet.identity.Models.AppRole", b =>
                {
                    b.Navigation("AppRoleClaims");

                    b.Navigation("AppUserRoles");
                });

            modelBuilder.Entity("brgy_mgmt_dotnet.identity.Models.AppUser", b =>
                {
                    b.Navigation("AppUserClaims");

                    b.Navigation("AppUserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
