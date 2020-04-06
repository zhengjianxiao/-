﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StreetLight.Models;

namespace StreetLight.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    [Migration("20200324050805_sensor")]
    partial class sensor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StreetLight.Models.Light", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celle")
                        .IsRequired();

                    b.Property<string>("Control")
                        .IsRequired();

                    b.Property<string>("Images");

                    b.Property<string>("Iswell")
                        .IsRequired();

                    b.Property<string>("Iswork")
                        .IsRequired();

                    b.Property<double>("Lat");

                    b.Property<double>("Lng");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhotoPath");

                    b.Property<string>("Sens")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Lights");
                });

            modelBuilder.Entity("StreetLight.Models.celled.Cellect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cellectsour");

                    b.Property<string>("Cellectwell");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cellects");
                });

            modelBuilder.Entity("StreetLight.Models.sensed.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Sensour");

                    b.Property<string>("Senwell");

                    b.HasKey("Id");

                    b.ToTable("Sensors");
                });
#pragma warning restore 612, 618
        }
    }
}
