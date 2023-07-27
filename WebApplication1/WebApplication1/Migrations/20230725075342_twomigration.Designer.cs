﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230725075342_twomigration")]
    partial class twomigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("WebApplication1.Data.DataInvoicesPay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DatePayment")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateScore")
                        .HasColumnType("datetime");

                    b.Property<int>("DayPay")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdClient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdPayment")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdScore")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kod")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Sum")
                        .HasColumnType("REAL");

                    b.Property<double>("SumPayment")
                        .HasColumnType("REAL");

                    b.Property<double>("SumScore")
                        .HasColumnType("REAL");

                    b.Property<string>("ViewPayment")
                        .HasColumnType("TEXT");

                    b.Property<string>("ViewScore")
                        .HasColumnType("TEXT");

                    b.Property<int>("payCondition")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("DataInvoicesPays");
                });
#pragma warning restore 612, 618
        }
    }
}
