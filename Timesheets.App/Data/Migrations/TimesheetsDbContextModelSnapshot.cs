﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Timesheets.App.Data;

#nullable disable

namespace Timesheets.App.Data.Migrations
{
    [DbContext(typeof(TimesheetsDbContext))]
    partial class TimesheetsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.22");

            modelBuilder.Entity("Timesheets.App.Data.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ContactTelephone")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BillingAddress = "123 Main St, Cityville",
                            CompanyName = "ABC Inc.",
                            ContactEmail = "john.doe@abcinc.com",
                            ContactName = "John Doe",
                            ContactTelephone = 5555555555L
                        },
                        new
                        {
                            Id = 2,
                            BillingAddress = "456 Oak Ave, Townsville",
                            CompanyName = "XYZ Corporation",
                            ContactEmail = "jane.smith@xyzcorp.com",
                            ContactName = "Jane Smith",
                            ContactTelephone = 5555555556L
                        },
                        new
                        {
                            Id = 3,
                            BillingAddress = "789 Elm Rd, Villagetown",
                            CompanyName = "123 Industries",
                            ContactEmail = "bob.johnson@123ind.com",
                            ContactName = "Bob Johnson",
                            ContactTelephone = 5555555557L
                        },
                        new
                        {
                            Id = 4,
                            BillingAddress = "101 Pine Ln, Hamletville",
                            CompanyName = "LMN Ltd.",
                            ContactEmail = "sarah.williams@lmnltd.com",
                            ContactName = "Sarah Williams",
                            ContactTelephone = 5555555558L
                        },
                        new
                        {
                            Id = 5,
                            BillingAddress = "202 Cedar Dr, Burgville",
                            CompanyName = "PQR Enterprises",
                            ContactEmail = "michael.davis@pqrent.com",
                            ContactName = "Michael Davis",
                            ContactTelephone = 5555555559L
                        });
                });

            modelBuilder.Entity("Timesheets.App.Data.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St, Cityville",
                            Name = "Main Office"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Oak Ave, Townsville",
                            Name = "Branch A"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Elm Rd, Villagetown",
                            Name = "Factory"
                        },
                        new
                        {
                            Id = 4,
                            Address = "101 Pine Ln, Hamletville",
                            Name = "Warehouse"
                        },
                        new
                        {
                            Id = 5,
                            Address = "202 Cedar Dr, Burgville",
                            Name = "Retail Store"
                        });
                });

            modelBuilder.Entity("Timesheets.App.Data.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ForeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "john.doe@example.com",
                            ForeName = "John",
                            SurName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jane.smith@example.com",
                            ForeName = "Jane",
                            SurName = "Smith"
                        },
                        new
                        {
                            Id = 3,
                            Email = "bob.johnson@example.com",
                            ForeName = "Bob",
                            SurName = "Johnson"
                        },
                        new
                        {
                            Id = 4,
                            Email = "sarah.williams@example.com",
                            ForeName = "Sarah",
                            SurName = "Williams"
                        },
                        new
                        {
                            Id = 5,
                            Email = "michael.davis@example.com",
                            ForeName = "Michael",
                            SurName = "Davis"
                        });
                });

            modelBuilder.Entity("Timesheets.App.Data.Timesheets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinutesWorked")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StaffId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("LocationId");

                    b.HasIndex("StaffId");

                    b.ToTable("Timesheets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 3,
                            LocationId = 2,
                            MinutesWorked = 480,
                            StaffId = 4
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 5,
                            LocationId = 1,
                            MinutesWorked = 520,
                            StaffId = 2
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 2,
                            LocationId = 4,
                            MinutesWorked = 420,
                            StaffId = 1
                        },
                        new
                        {
                            Id = 4,
                            ClientId = 4,
                            LocationId = 3,
                            MinutesWorked = 450,
                            StaffId = 5
                        },
                        new
                        {
                            Id = 5,
                            ClientId = 1,
                            LocationId = 5,
                            MinutesWorked = 490,
                            StaffId = 3
                        });
                });

            modelBuilder.Entity("Timesheets.App.Data.Timesheets", b =>
                {
                    b.HasOne("Timesheets.App.Data.Client", "Client")
                        .WithMany("Timesheets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Timesheets.App.Data.Location", "Location")
                        .WithMany("Timesheets")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Timesheets.App.Data.Staff", "Staff")
                        .WithMany("Timesheets")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Location");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Timesheets.App.Data.Client", b =>
                {
                    b.Navigation("Timesheets");
                });

            modelBuilder.Entity("Timesheets.App.Data.Location", b =>
                {
                    b.Navigation("Timesheets");
                });

            modelBuilder.Entity("Timesheets.App.Data.Staff", b =>
                {
                    b.Navigation("Timesheets");
                });
#pragma warning restore 612, 618
        }
    }
}
