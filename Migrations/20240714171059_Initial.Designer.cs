﻿// <auto-generated />
using System;
using Dex_Filter.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dex_Filter.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20240714171059_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dex_Filter.Models.Token", b =>
                {
                    b.Property<int?>("chainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("chainId"));

                    b.Property<string>("Ticker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pairAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("chainId");

                    b.ToTable("Tokens");
                });
#pragma warning restore 612, 618
        }
    }
}
