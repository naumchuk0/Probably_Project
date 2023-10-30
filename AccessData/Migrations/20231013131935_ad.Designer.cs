﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Probably_Project.Data;

#nullable disable

namespace AccessData.Migrations
{
    [DbContext(typeof(MovieDB))]
    [Migration("20231013131935_ad")]
    partial class ad
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AccessData.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
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

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Probably_Project.Data.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ireland"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Germany"
                        },
                        new
                        {
                            Id = 4,
                            Name = "China"
                        },
                        new
                        {
                            Id = 5,
                            Name = "USA"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Japan"
                        },
                        new
                        {
                            Id = 7,
                            Name = "India"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Mexico"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Spain"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Poland"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Sweden"
                        });
                });

            modelBuilder.Entity("Probably_Project.Data.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("GraduationYear")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("GenreId");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 2,
                            Description = "test1",
                            Duration = 15,
                            GenreId = 2,
                            GraduationYear = 2023,
                            Img = "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png",
                            Title = "Test1",
                            Video = "video (2160p).mp4",
                            Views = 1
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 7,
                            Description = "test2",
                            Duration = 15,
                            GenreId = 6,
                            GraduationYear = 1999,
                            Img = "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png",
                            Title = "Test2",
                            Video = "video (2160p).mp4",
                            Views = 123123
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            Description = "test3",
                            Duration = 15,
                            GenreId = 1,
                            GraduationYear = 2077,
                            Img = "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png",
                            Title = "Test3",
                            Video = "video (2160p).mp4",
                            Views = 4127
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 5,
                            Description = "test4",
                            Duration = 15,
                            GenreId = 3,
                            GraduationYear = 2013,
                            Img = "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png",
                            Title = "Test4",
                            Video = "video (2160p).mp4",
                            Views = 19
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 2,
                            Description = "test5",
                            Duration = 15,
                            GenreId = 2,
                            GraduationYear = 2023,
                            Img = "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png",
                            Title = "Test5",
                            Video = "video (2160p).mp4",
                            Views = 1
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 7,
                            Description = "test6",
                            Duration = 15,
                            GenreId = 6,
                            GraduationYear = 1999,
                            Img = "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png",
                            Title = "Test6",
                            Video = "video-1658576887.mp4",
                            Views = 123123
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 1,
                            Description = "test7",
                            Duration = 15,
                            GenreId = 1,
                            GraduationYear = 2077,
                            Img = "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png",
                            Title = "Test7",
                            Video = "video-1658576887.mp4",
                            Views = 4127
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 5,
                            Description = "test8",
                            Duration = 15,
                            GenreId = 3,
                            GraduationYear = 2013,
                            Img = "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png",
                            Title = "Test8",
                            Video = "video-1658576887.mp4",
                            Views = 19
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 2,
                            Description = "test9",
                            Duration = 15,
                            GenreId = 2,
                            GraduationYear = 2023,
                            Img = "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png",
                            Title = "Test9",
                            Video = "video (2160p).mp4",
                            Views = 1
                        },
                        new
                        {
                            Id = 10,
                            CountryId = 7,
                            Description = "test10",
                            Duration = 15,
                            GenreId = 6,
                            GraduationYear = 1999,
                            Img = "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png",
                            Title = "Test10",
                            Video = "video (2160p).mp4",
                            Views = 123123
                        },
                        new
                        {
                            Id = 11,
                            CountryId = 1,
                            Description = "test11",
                            Duration = 15,
                            GenreId = 1,
                            GraduationYear = 2077,
                            Img = "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png",
                            Title = "Test11",
                            Video = "video (2160p).mp4",
                            Views = 4127
                        },
                        new
                        {
                            Id = 12,
                            CountryId = 5,
                            Description = "test12",
                            Duration = 15,
                            GenreId = 3,
                            GraduationYear = 2013,
                            Img = "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png",
                            Title = "Test12",
                            Video = "video (2160p).mp4",
                            Views = 19
                        },
                        new
                        {
                            Id = 13,
                            CountryId = 8,
                            Description = "test13",
                            Duration = 3,
                            GenreId = 8,
                            GraduationYear = 2122,
                            Img = "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png",
                            Title = "Test13",
                            Video = "video-1658576887.mp4",
                            Views = 123
                        });
                });

            modelBuilder.Entity("Probably_Project.Data.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Documentary"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Musical"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Western"
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
                    b.HasOne("AccessData.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AccessData.Data.Entities.User", null)
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

                    b.HasOne("AccessData.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AccessData.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Probably_Project.Data.Entities.Film", b =>
                {
                    b.HasOne("Probably_Project.Data.Entities.Country", "Country")
                        .WithMany("Films")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Probably_Project.Data.Entities.Genre", "Genre")
                        .WithMany("Films")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Probably_Project.Data.Entities.Country", b =>
                {
                    b.Navigation("Films");
                });

            modelBuilder.Entity("Probably_Project.Data.Entities.Genre", b =>
                {
                    b.Navigation("Films");
                });
#pragma warning restore 612, 618
        }
    }
}
