﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieWebApp.Data;

namespace MovieWebApp.Migrations.ApplicationDB
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20201109201144_IdentityUserToTable")]
    partial class IdentityUserToTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieWebApp.Data.Movies", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CheckedOut")
                        .HasColumnType("bit");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Runtime")
                        .HasColumnType("float");

                    b.Property<string>("UserCheckedOut")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CheckedOut = false,
                            Genre = "Anitmation",
                            Name = "The Little Mermaid",
                            Runtime = 1.54
                        },
                        new
                        {
                            ID = 2,
                            CheckedOut = false,
                            Genre = "Action",
                            Name = "Pirates of The Caribbean",
                            Runtime = 1.54
                        },
                        new
                        {
                            ID = 3,
                            CheckedOut = false,
                            Genre = "Romantic Comedy",
                            Name = "When Harry Met Sally",
                            Runtime = 1.54
                        },
                        new
                        {
                            ID = 4,
                            CheckedOut = false,
                            Genre = "Drama",
                            Name = "The Imitation Game",
                            Runtime = 1.54
                        },
                        new
                        {
                            ID = 5,
                            CheckedOut = true,
                            Genre = "Biopic",
                            Name = "Hidden Figures",
                            Runtime = 1.54
                        });
                });
#pragma warning restore 612, 618
        }
    }
}