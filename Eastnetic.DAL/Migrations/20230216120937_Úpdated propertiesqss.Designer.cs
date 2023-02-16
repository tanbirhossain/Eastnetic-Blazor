﻿// <auto-generated />
using Eastnetic.DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Eastnetic.DAL.Migrations
{
    [DbContext(typeof(EastneticDbContext))]
    [Migration("20230216120937_Úpdated propertiesqss")]
    partial class Úpdatedpropertiesqss
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Eastnetic.DAL.Domain.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("Eastnetic.DAL.Domain.Entities.SubElement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("Element")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.Property<long>("WindowId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("WindowId");

                    b.ToTable("SubElement", (string)null);
                });

            modelBuilder.Entity("Eastnetic.DAL.Domain.Entities.Window", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<int>("QuantityOfWindows")
                        .HasColumnType("int");

                    b.Property<int>("TotalSubElements")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Window", (string)null);
                });

            modelBuilder.Entity("Eastnetic.DAL.Domain.Entities.SubElement", b =>
                {
                    b.HasOne("Eastnetic.DAL.Domain.Entities.Window", "Window")
                        .WithMany("SubElements")
                        .HasForeignKey("WindowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SubElement_Window");

                    b.Navigation("Window");
                });

            modelBuilder.Entity("Eastnetic.DAL.Domain.Entities.Window", b =>
                {
                    b.HasOne("Eastnetic.DAL.Domain.Entities.Order", "Order")
                        .WithMany("Windows")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Window_Order");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Eastnetic.DAL.Domain.Entities.Order", b =>
                {
                    b.Navigation("Windows");
                });

            modelBuilder.Entity("Eastnetic.DAL.Domain.Entities.Window", b =>
                {
                    b.Navigation("SubElements");
                });
#pragma warning restore 612, 618
        }
    }
}
