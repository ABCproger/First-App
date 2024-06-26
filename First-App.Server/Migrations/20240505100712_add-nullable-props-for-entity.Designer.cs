﻿// <auto-generated />
using System;
using First_App.Server.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace First_App.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240505100712_add-nullable-props-for-entity")]
    partial class addnullablepropsforentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("First_App.Server.Entities.Board", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Boards");
                });

            modelBuilder.Entity("First_App.Server.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CardColumnId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("due_date");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("CardColumnId");

                    b.ToTable("cards");
                });

            modelBuilder.Entity("First_App.Server.Entities.CardColumn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BoardId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.ToTable("CardColumns");
                });

            modelBuilder.Entity("First_App.Server.Entities.Card", b =>
                {
                    b.HasOne("First_App.Server.Entities.CardColumn", "CardColumn")
                        .WithMany("Cards")
                        .HasForeignKey("CardColumnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardColumn");
                });

            modelBuilder.Entity("First_App.Server.Entities.CardColumn", b =>
                {
                    b.HasOne("First_App.Server.Entities.Board", null)
                        .WithMany("Columns")
                        .HasForeignKey("BoardId");
                });

            modelBuilder.Entity("First_App.Server.Entities.Board", b =>
                {
                    b.Navigation("Columns");
                });

            modelBuilder.Entity("First_App.Server.Entities.CardColumn", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
