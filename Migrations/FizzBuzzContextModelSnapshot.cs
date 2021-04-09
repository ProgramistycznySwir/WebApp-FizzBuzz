﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp_FizzBuzz.Data;

namespace WebApp_FizzBuzz.Migrations
{
    [DbContext(typeof(FizzBuzzContext))]
    partial class FizzBuzzContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp_FizzBuzz.Models.FizzBuzzEntry", b =>
                {
                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("entry")
                        .HasColumnType("int");

                    b.Property<string>("result")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("date");

                    b.ToTable("FizzBuzzEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
