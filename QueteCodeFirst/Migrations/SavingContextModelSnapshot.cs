﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QueteCodeFirst.Data;

#nullable disable

namespace QueteCodeFirst.Migrations
{
    [DbContext(typeof(SavingContext))]
    partial class SavingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QueteCodeFirst.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("QueteCodeFirst.Models.SavingAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<double>("SavingsRate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("SavingAccounts");
                });

            modelBuilder.Entity("QueteCodeFirst.Models.SavingCalculator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("SavingCalculators");
                });

            modelBuilder.Entity("QueteCodeFirst.Models.SavingAccount", b =>
                {
                    b.HasOne("QueteCodeFirst.Models.Person", null)
                        .WithMany("SavingAccounts")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("QueteCodeFirst.Models.Person", b =>
                {
                    b.Navigation("SavingAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
