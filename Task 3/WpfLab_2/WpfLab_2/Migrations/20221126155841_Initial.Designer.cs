﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WpfLab_2;

#nullable disable

namespace WpfLab3.Migrations
{
    [DbContext(typeof(DataBase))]
    [Migration("20221126155841_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("WpfLab_2.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DetailsId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Embedding")
                        .HasColumnType("BLOB");

                    b.Property<string>("Hash")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DetailsId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("WpfLab_2.Image_Info", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Data")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("WpfLab_2.Image", b =>
                {
                    b.HasOne("WpfLab_2.Image_Info", "Details")
                        .WithMany()
                        .HasForeignKey("DetailsId");

                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}