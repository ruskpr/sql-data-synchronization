﻿// <auto-generated />
using System;
using Lib.Core.EF.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lib.Migrations.SqlServer
{
    [DbContext(typeof(SqlServerContext))]
    partial class SqlServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lib.Core.EF.DbObjects.DataEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("UOM1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UOM1Value")
                        .HasColumnType("float");

                    b.Property<string>("UOM2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UOM2Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("DataEntries");
                });

            modelBuilder.Entity("Lib.Core.EF.DbObjects.SynchronizationEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RecordsAdded")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeSynced")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Synchronizations");
                });
#pragma warning restore 612, 618
        }
    }
}
