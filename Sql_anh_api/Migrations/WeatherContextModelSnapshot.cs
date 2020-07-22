﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sql_anh_api.Models;

namespace Sql_anh_api.Migrations
{
    [DbContext(typeof(WeatherContext))]
    partial class WeatherContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sql_anh_api.Models.Weather", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Datetime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Humidity")
                        .HasColumnType("bigint");

                    b.Property<long>("TempC")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("weathers");
                });
#pragma warning restore 612, 618
        }
    }
}
