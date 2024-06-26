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
    [Migration("20240508051528_add-priority")]
    partial class addpriority
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

                    b.HasData(
                        new
                        {
                            Id = 20,
                            Name = "testBoard"
                        },
                        new
                        {
                            Id = 21,
                            Name = "secondTestBoard"
                        });
                });

            modelBuilder.Entity("First_App.Server.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CardColumnId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("due_date");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int?>("PriorityId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CardColumnId");

                    b.HasIndex("PriorityId");

                    b.ToTable("cards");

                    b.HasData(
                        new
                        {
                            Id = 20,
                            CardColumnId = 20,
                            Description = "some description for first card",
                            DueDate = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "first card"
                        },
                        new
                        {
                            Id = 21,
                            CardColumnId = 20,
                            Description = "some description for second card",
                            DueDate = new DateTime(2025, 4, 12, 4, 13, 2, 0, DateTimeKind.Utc),
                            Name = "second card"
                        },
                        new
                        {
                            Id = 22,
                            CardColumnId = 20,
                            Description = "some description for third card",
                            DueDate = new DateTime(2024, 4, 3, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "third card"
                        },
                        new
                        {
                            Id = 23,
                            CardColumnId = 20,
                            Description = "some description for fourth card",
                            DueDate = new DateTime(2024, 1, 12, 12, 13, 2, 0, DateTimeKind.Utc),
                            Name = "fourth card"
                        },
                        new
                        {
                            Id = 24,
                            CardColumnId = 20,
                            Description = "some description for fifth card",
                            DueDate = new DateTime(2024, 4, 2, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "fifth card"
                        },
                        new
                        {
                            Id = 25,
                            CardColumnId = 21,
                            Description = "some description second column card",
                            DueDate = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "second column card"
                        },
                        new
                        {
                            Id = 26,
                            CardColumnId = 21,
                            Description = "some description second column card2",
                            DueDate = new DateTime(2024, 4, 8, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "second column card2"
                        },
                        new
                        {
                            Id = 27,
                            CardColumnId = 21,
                            Description = "some description second column card3",
                            DueDate = new DateTime(2024, 4, 9, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "second column card3"
                        },
                        new
                        {
                            Id = 28,
                            CardColumnId = 21,
                            Description = "some description for second column card4",
                            DueDate = new DateTime(2024, 4, 11, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "second column card4"
                        },
                        new
                        {
                            Id = 29,
                            CardColumnId = 21,
                            Description = "some description for second column card5",
                            DueDate = new DateTime(2024, 4, 10, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "second column card5"
                        });
                });

            modelBuilder.Entity("First_App.Server.Entities.CardActivityLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Action")
                        .HasColumnType("text");

                    b.Property<DateTime>("ActivityTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CardId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("CardActivityLogs");
                });

            modelBuilder.Entity("First_App.Server.Entities.CardColumn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BoardId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.ToTable("CardColumns");

                    b.HasData(
                        new
                        {
                            Id = 20,
                            BoardId = 20,
                            Name = "first column"
                        },
                        new
                        {
                            Id = 21,
                            BoardId = 20,
                            Name = "second column"
                        });
                });

            modelBuilder.Entity("First_App.Server.Entities.Priority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Priority");
                });

            modelBuilder.Entity("First_App.Server.Entities.Card", b =>
                {
                    b.HasOne("First_App.Server.Entities.CardColumn", "CardColumn")
                        .WithMany("Cards")
                        .HasForeignKey("CardColumnId");

                    b.HasOne("First_App.Server.Entities.Priority", "Priority")
                        .WithMany("Cards")
                        .HasForeignKey("PriorityId");

                    b.Navigation("CardColumn");

                    b.Navigation("Priority");
                });

            modelBuilder.Entity("First_App.Server.Entities.CardActivityLog", b =>
                {
                    b.HasOne("First_App.Server.Entities.Card", "Card")
                        .WithMany("CardActivityLogs")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");
                });

            modelBuilder.Entity("First_App.Server.Entities.CardColumn", b =>
                {
                    b.HasOne("First_App.Server.Entities.Board", "Boards")
                        .WithMany("Columns")
                        .HasForeignKey("BoardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boards");
                });

            modelBuilder.Entity("First_App.Server.Entities.Board", b =>
                {
                    b.Navigation("Columns");
                });

            modelBuilder.Entity("First_App.Server.Entities.Card", b =>
                {
                    b.Navigation("CardActivityLogs");
                });

            modelBuilder.Entity("First_App.Server.Entities.CardColumn", b =>
                {
                    b.Navigation("Cards");
                });

            modelBuilder.Entity("First_App.Server.Entities.Priority", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
