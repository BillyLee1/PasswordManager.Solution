﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PasswordManager.Models;

#nullable disable

namespace PasswordManager.Migrations
{
    [DbContext(typeof(PasswordManagerContext))]
    [Migration("20230702214249_AddNewVariable")]
    partial class AddNewVariable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PasswordManager.Models.Password", b =>
                {
                    b.Property<int>("PasswordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Site")
                        .HasColumnType("longtext");

                    b.Property<string>("SiteEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("SitePassword")
                        .HasColumnType("longtext");

                    b.Property<string>("SiteUsername")
                        .HasColumnType("longtext");

                    b.HasKey("PasswordId");

                    b.ToTable("Passwords");
                });
#pragma warning restore 612, 618
        }
    }
}
