﻿// <auto-generated />
using System;
using DataDonation.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataDonation.Migrations {
  [DbContext(typeof(DatabaseContext))]
  [Migration("20220517231840_dotnet-update")]
  partial class dotnetupdate {
    protected override void BuildTargetModel(ModelBuilder modelBuilder) {
#pragma warning disable 612, 618
      modelBuilder.HasAnnotation("ProductVersion", "6.0.5")
          .HasAnnotation("Relational:MaxIdentifierLength", 64);

      modelBuilder.Entity("DataDonation.Models.DataDonationEntry", b => {
        b.Property<Guid>("Id").ValueGeneratedOnAdd().HasColumnType(
            "binary(16)");

        b.Property<string>("data").HasColumnType("longtext");

        b.Property<DateTime>("date").HasColumnType("datetime(6)");

        b.HasKey("Id");

        b.ToTable("DataDonationEntries");
      });
#pragma warning restore 612, 618
    }
  }
}