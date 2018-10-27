﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MvcPractice1.Models;
using System;

namespace MvcPractice1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181027183748_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcPractice1.Models.Item", b =>
                {
                    b.Property<int>("ItemId");

                    b.Property<decimal>("Cost");

                    b.Property<string>("Description");

                    b.Property<decimal>("SellingPrice");

                    b.Property<int>("UnitsOnHand");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}