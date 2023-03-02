﻿// <auto-generated />
using System;
using Lib.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lib.Migrations.Sqlite
{
    [DbContext(typeof(SqliteContext))]
    [Migration("20230301181446_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("Lib.DbObjects.DataEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DeviceTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("UOM1Id")
                        .HasColumnType("INTEGER");

                    b.Property<double>("UOM1Value")
                        .HasColumnType("REAL");

                    b.Property<int>("UOM2Id")
                        .HasColumnType("INTEGER");

                    b.Property<double>("UOM2Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("DeviceTypeId");

                    b.HasIndex("UOM1Id");

                    b.HasIndex("UOM2Id");

                    b.ToTable("DataEntries");
                });

            modelBuilder.Entity("Lib.DbObjects.DeviceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DeviceTypes");
                });

            modelBuilder.Entity("Lib.DbObjects.SynchronizationEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecordsAdded")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeSynced")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Synchronizations");
                });

            modelBuilder.Entity("Lib.DbObjects.UnitOfMeasure1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UnitOfMeasure")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UnitsOfMeasure1");
                });

            modelBuilder.Entity("Lib.DbObjects.UnitOfMeasure2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UnitOfMeasure")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UnitsOfMeasure2");
                });

            modelBuilder.Entity("Lib.DbObjects.DataEntry", b =>
                {
                    b.HasOne("Lib.DbObjects.DeviceType", "DeviceType")
                        .WithMany()
                        .HasForeignKey("DeviceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.DbObjects.UnitOfMeasure1", "UOM1")
                        .WithMany()
                        .HasForeignKey("UOM1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.DbObjects.UnitOfMeasure2", "UOM2")
                        .WithMany()
                        .HasForeignKey("UOM2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeviceType");

                    b.Navigation("UOM1");

                    b.Navigation("UOM2");
                });
#pragma warning restore 612, 618
        }
    }
}