﻿// <auto-generated />
using ApiCoreAngular.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiCoreAngular.Migrations
{
    [DbContext(typeof(UserFormContext))]
    partial class UserFormContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiCoreAngular.Models.UserFormDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("age")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("birthday")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("jobs")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("UserFormDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
