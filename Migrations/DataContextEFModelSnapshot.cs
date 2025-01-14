﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RealEstateAPI.data;

#nullable disable

namespace RealEstateAPI.Migrations
{
    [DbContext(typeof(DataContextEF))]
    partial class DataContextEFModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("RealEstate")
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RealEstateAPI.Models.Apartment", b =>
                {
                    b.Property<Guid>("ApartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DistanceToBusStop")
                        .HasColumnType("integer");

                    b.Property<int>("DistanceToRestaurant")
                        .HasColumnType("integer");

                    b.Property<int>("DistanceToSchool")
                        .HasColumnType("integer");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<int>("NumberOfBathrooms")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfBeds")
                        .HasColumnType("integer");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PetPolicy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PropertyFees")
                        .HasColumnType("text");

                    b.Property<decimal>("Rent")
                        .HasColumnType("numeric");

                    b.Property<int>("SizeInSqft")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Utilities")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ApartmentId");

                    b.ToTable("Apartments", "RealEstate");
                });
#pragma warning restore 612, 618
        }
    }
}
