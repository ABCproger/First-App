﻿// <auto-generated />
using System;
using First_App.Server.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace First_App.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("CardColumnId")
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

                    b.Property<int>("PriorityId")
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
                            Name = "first card",
                            PriorityId = 1
                        },
                        new
                        {
                            Id = 21,
                            CardColumnId = 20,
                            Description = "some description for second card",
                            DueDate = new DateTime(2025, 4, 12, 4, 13, 2, 0, DateTimeKind.Utc),
                            Name = "second card",
                            PriorityId = 2
                        },
                        new
                        {
                            Id = 22,
                            CardColumnId = 20,
                            Description = "some description for third card",
                            DueDate = new DateTime(2024, 4, 3, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "third card",
                            PriorityId = 1
                        },
                        new
                        {
                            Id = 23,
                            CardColumnId = 20,
                            Description = "some description for fourth card",
                            DueDate = new DateTime(2024, 1, 12, 12, 13, 2, 0, DateTimeKind.Utc),
                            Name = "fourth card",
                            PriorityId = 2
                        },
                        new
                        {
                            Id = 24,
                            CardColumnId = 20,
                            Description = "some description for fifth card",
                            DueDate = new DateTime(2024, 4, 2, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "fifth card",
                            PriorityId = 1
                        },
                        new
                        {
                            Id = 25,
                            CardColumnId = 21,
                            Description = "some description second column card",
                            DueDate = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "second column card",
                            PriorityId = 1
                        },
                        new
                        {
                            Id = 26,
                            CardColumnId = 21,
                            Description = "some description second column card2",
                            DueDate = new DateTime(2024, 4, 8, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "second column card2",
                            PriorityId = 3
                        },
                        new
                        {
                            Id = 27,
                            CardColumnId = 21,
                            Description = "some description second column card3",
                            DueDate = new DateTime(2024, 4, 9, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "second column card3",
                            PriorityId = 3
                        },
                        new
                        {
                            Id = 28,
                            CardColumnId = 21,
                            Description = "some description for second column card4",
                            DueDate = new DateTime(2024, 4, 11, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "second column card4",
                            PriorityId = 3
                        },
                        new
                        {
                            Id = 29,
                            CardColumnId = 21,
                            Description = "some description for second column card5",
                            DueDate = new DateTime(2024, 4, 10, 2, 13, 2, 0, DateTimeKind.Utc),
                            Name = "second column card5",
                            PriorityId = 1
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

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Action = "You created this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 20
                        },
                        new
                        {
                            Id = 101,
                            Action = "You created this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 21
                        },
                        new
                        {
                            Id = 102,
                            Action = "You created this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 22
                        },
                        new
                        {
                            Id = 103,
                            Action = "You created this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 23
                        },
                        new
                        {
                            Id = 104,
                            Action = "You created this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 24
                        },
                        new
                        {
                            Id = 105,
                            Action = "You created this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 25
                        },
                        new
                        {
                            Id = 106,
                            Action = "You created this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 26
                        },
                        new
                        {
                            Id = 107,
                            Action = "You created this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 27
                        },
                        new
                        {
                            Id = 108,
                            Action = "You created this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 28
                        },
                        new
                        {
                            Id = 109,
                            Action = "You created this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 29
                        },
                        new
                        {
                            Id = 110,
                            Action = "You renamed first card to first card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 20
                        },
                        new
                        {
                            Id = 111,
                            Action = "You moved second card from To Do to Planned",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 21
                        },
                        new
                        {
                            Id = 112,
                            Action = "You deleted third card from to do",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 22
                        },
                        new
                        {
                            Id = 113,
                            Action = "You changed the priority fourth card from low to medium",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 23
                        },
                        new
                        {
                            Id = 114,
                            Action = "You do something with this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 24
                        },
                        new
                        {
                            Id = 115,
                            Action = "You do something with this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 25
                        },
                        new
                        {
                            Id = 116,
                            Action = "You do something with this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 26
                        },
                        new
                        {
                            Id = 117,
                            Action = "You do something with this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 27
                        },
                        new
                        {
                            Id = 118,
                            Action = "You do something with this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 28
                        },
                        new
                        {
                            Id = 119,
                            Action = "You do something with this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 29
                        },
                        new
                        {
                            Id = 120,
                            Action = "You do something with this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 20
                        },
                        new
                        {
                            Id = 121,
                            Action = "You do something with this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 21
                        },
                        new
                        {
                            Id = 122,
                            Action = "You do something with this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 22
                        },
                        new
                        {
                            Id = 123,
                            Action = "You do something with this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 23
                        },
                        new
                        {
                            Id = 124,
                            Action = "You do something with this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 24
                        },
                        new
                        {
                            Id = 125,
                            Action = "You do something with this card",
                            ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc),
                            CardId = 25
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Low"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Medium"
                        },
                        new
                        {
                            Id = 3,
                            Name = "High"
                        });
                });

            modelBuilder.Entity("First_App.Server.Entities.Card", b =>
                {
                    b.HasOne("First_App.Server.Entities.CardColumn", "CardColumn")
                        .WithMany("Cards")
                        .HasForeignKey("CardColumnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("First_App.Server.Entities.Priority", "Priority")
                        .WithMany("Cards")
                        .HasForeignKey("PriorityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
