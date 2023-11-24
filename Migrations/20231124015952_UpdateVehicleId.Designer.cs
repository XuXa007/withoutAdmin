﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication7.Data;

#nullable disable

namespace WebApplication7.Migrations
{
    [DbContext(typeof(WebApplication7Context))]
    [Migration("20231124015952_UpdateVehicleId")]
    partial class UpdateVehicleId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApplication7.Models.MaintenanceReport", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RequestId"));

                    b.Property<string>("MaintenanceType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("VehicleId")
                        .HasColumnType("integer");

                    b.HasKey("RequestId");

                    b.HasIndex("VehicleId");

                    b.ToTable("MaintenanceReport");
                });

            modelBuilder.Entity("WebApplication7.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("LastServiceDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OdometerReading")
                        .HasColumnType("integer");

                    b.Property<string>("OwnerContact")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("WebApplication7.Models.MaintenanceReport", b =>
                {
                    b.HasOne("WebApplication7.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId");

                    b.Navigation("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
