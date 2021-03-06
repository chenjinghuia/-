﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCompany.EntityFrameworkCore;

namespace MyCompany.Migrations
{
    [DbContext(typeof(MyCompanyDbContext))]
    partial class MyCompanyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyCompany.Customers.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<Guid?>("CustomerId");

                    b.Property<string>("KHName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Sex");

                    b.Property<string>("Telephone");

                    b.Property<int>("TransactionNumber");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MyCompany.Customers.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("KHName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("OderAddress");

                    b.Property<string>("OderMoney");

                    b.Property<int>("OrderID");

                    b.Property<DateTime>("OrderOverTime");

                    b.Property<DateTime>("OrderStartTime");

                    b.Property<string>("ServiceEployee");

                    b.HasKey("Id");

                    b.ToTable(" Order");
                });

            modelBuilder.Entity("MyCompany.Employee.Basic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Area");

                    b.Property<DateTime>("CreationTime");

                    b.Property<Guid?>("EmployeeId")
                        .IsRequired();

                    b.Property<byte>("Handle");

                    b.Property<string>("Identity");

                    b.Property<string>("Introduction");

                    b.Property<string>("Professional");

                    b.Property<string>("Qualification");

                    b.Property<string>("Sex");

                    b.Property<string>("Telephone");

                    b.Property<string>("TypeService");

                    b.Property<string>("YGName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Basic");
                });

            modelBuilder.Entity("MyCompany.Employee.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerData");

                    b.Property<string>("CustomerEvaluation");

                    b.Property<string>("Log");

                    b.Property<DateTime>("ServiceOverTime");

                    b.Property<DateTime>("ServiceStartTime");

                    b.Property<string>("YGName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable(" Record");
                });

            modelBuilder.Entity("MyCompany.Customers.Customer", b =>
                {
                    b.HasOne("MyCompany.Customers.Order", "OrderCustomer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("MyCompany.Employee.Basic", b =>
                {
                    b.HasOne("MyCompany.Employee.Record", "EmployeeRecord")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
