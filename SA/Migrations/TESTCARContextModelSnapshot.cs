﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SA.Models;

namespace SA.Migrations
{
    [DbContext(typeof(TESTCARContext))]
    partial class TESTCARContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
        #pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SA.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body_Type")
                        .HasColumnName("body_type")
                        .HasMaxLength(50);

                    b.Property<string>("Contact")
                        .HasColumnName("contact")
                        .HasMaxLength(50);

                    b.Property<decimal?>("Engine_Size")
                        .HasColumnName("engine_size")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<string>("Fuel_Type")
                        .HasColumnName("fuel_type")
                        .HasMaxLength(50);

                    b.Property<string>("Image");

                    b.Property<int?>("Is_Deleted")
                        .HasColumnName("is_deleted");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnName("make")
                        .HasMaxLength(50);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnName("model")
                        .HasMaxLength(50);

                    b.Property<string>("OriginalImageName");

                    b.Property<int?>("Power_Kw")
                        .HasColumnName("power_kw");

                    b.Property<decimal?>("Price")
                        .HasColumnName("price")
                        .HasColumnType("money");

                    b.Property<int?>("Year")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.ToTable("Car");
                });
              #pragma warning restore 612, 618
        }
    }
}
