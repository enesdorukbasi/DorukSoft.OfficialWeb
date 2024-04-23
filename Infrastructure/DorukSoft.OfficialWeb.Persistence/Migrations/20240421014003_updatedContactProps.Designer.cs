﻿// <auto-generated />
using System;
using DorukSoft.OfficialWeb.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DorukSoft.OfficialWeb.Persistence.Migrations
{
    [DbContext(typeof(MSSqlContext))]
    [Migration("20240421014003_updatedContactProps")]
    partial class updatedContactProps
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.Entities.AppRole", b =>
                {
                    b.Property<int>("AppRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppRoleId"));

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppRoleId");

                    b.ToTable("AppRoles");

                    b.HasData(
                        new
                        {
                            AppRoleId = 1,
                            Definition = "SuperAdmin"
                        },
                        new
                        {
                            AppRoleId = 2,
                            Definition = "Admin"
                        });
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.Entities.AppUser", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppUserId"));

                    b.Property<int>("AppRoleId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppUserId");

                    b.HasIndex("AppRoleId");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            AppUserId = 1,
                            AppRoleId = 1,
                            Email = "enesdorukbasi@outlook.com",
                            IsActive = true,
                            Name = "Enes",
                            Password = "MCAmEauWLyp3ej1O2TnhlY5MUttOtQT6jo2p/DIE7a4=",
                            Surname = "Dorukbaşı"
                        },
                        new
                        {
                            AppUserId = 2,
                            AppRoleId = 2,
                            Email = "enesdirukbasi@gmail.com",
                            IsActive = true,
                            Name = "Enes",
                            Password = "oyBID1NHdr3bXNtUsek9IQo8fRmegKI8GyF4SXsYTHY=",
                            Surname = "Dorukbaşı"
                        });
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.PageEntities.AboutPage", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutId");

                    b.ToTable("AboutPages");

                    b.HasData(
                        new
                        {
                            AboutId = 1,
                            Content = "null",
                            Title = "null"
                        });
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.PageEntities.GenericPage", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PageId"));

                    b.Property<string>("ListItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PageType")
                        .HasColumnType("int");

                    b.HasKey("PageId");

                    b.ToTable("GenericPages");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsShowMainPage")
                        .HasColumnType("bit");

                    b.Property<string>("Keywords")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsShowMainPage")
                        .HasColumnType("bit");

                    b.Property<string>("Keywords")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.CompanyInformation", b =>
                {
                    b.Property<int>("CompanyInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyInformationId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhatsappPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyInformationId");

                    b.ToTable("CompanyInformations");

                    b.HasData(
                        new
                        {
                            CompanyInformationId = 1,
                            Address = "Adresi",
                            CompanyName = "Şirket Adı",
                            CompanyTitle = "Şirket Title",
                            Email = "Şirket Mail",
                            PhoneNumber = "Telefon Numarası",
                            WhatsappPhoneNumber = "Whatsapp Numarası"
                        });
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShowedAdminMails")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("ProductId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.ContactAfterChatMessage", b =>
                {
                    b.Property<int>("ContactAfterChatMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactAfterChatMessageId"));

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactAfterChatMessageId");

                    b.HasIndex("ContactId");

                    b.ToTable("ContactAfterChatMessages");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keywords")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductSalesType")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Tax")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.SocialMedia", b =>
                {
                    b.Property<int>("SocialMediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SocialMediaId"));

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocialMediaId");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ThemeEntities.Banner", b =>
                {
                    b.Property<int>("BannerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BannerId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsShowAboutPage")
                        .HasColumnType("bit");

                    b.Property<bool>("IsShowMainPage")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BannerId");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ThemeEntities.Slider", b =>
                {
                    b.Property<int>("SliderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SliderId"));

                    b.Property<string>("SliderContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SliderId");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ThemeEntities.ViewerPageMedia", b =>
                {
                    b.Property<int>("MediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MediaId"));

                    b.Property<string>("MediaExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MediaUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewerPageId")
                        .HasColumnType("int");

                    b.HasKey("MediaId");

                    b.HasIndex("ViewerPageId");

                    b.ToTable("ViewerPageMedias");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.Entities.AppUser", b =>
                {
                    b.HasOne("DorukSoft.OfficialWeb.Domain.Entities.AppRole", "AppRole")
                        .WithMany("AppUsers")
                        .HasForeignKey("AppRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.Category", b =>
                {
                    b.HasOne("DorukSoft.OfficialWeb.Domain.ProgramEntities.Category", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.Contact", b =>
                {
                    b.HasOne("DorukSoft.OfficialWeb.Domain.ProgramEntities.Product", "Product")
                        .WithMany("ContactForProduct")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.ContactAfterChatMessage", b =>
                {
                    b.HasOne("DorukSoft.OfficialWeb.Domain.ProgramEntities.Contact", "Contact")
                        .WithMany("ChatMessages")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.Product", b =>
                {
                    b.HasOne("DorukSoft.OfficialWeb.Domain.ProgramEntities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ThemeEntities.ViewerPageMedia", b =>
                {
                    b.HasOne("DorukSoft.OfficialWeb.Domain.PageEntities.GenericPage", "ViewerPage")
                        .WithMany("ViewerPageMedias")
                        .HasForeignKey("ViewerPageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ViewerPage");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.Entities.AppRole", b =>
                {
                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.PageEntities.GenericPage", b =>
                {
                    b.Navigation("ViewerPageMedias");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.Contact", b =>
                {
                    b.Navigation("ChatMessages");
                });

            modelBuilder.Entity("DorukSoft.OfficialWeb.Domain.ProgramEntities.Product", b =>
                {
                    b.Navigation("ContactForProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
