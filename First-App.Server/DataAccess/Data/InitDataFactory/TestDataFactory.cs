﻿using First_App.Server.Entities;

namespace First_App.Server.DataAccess.Data.InitDataFactory
{
    public class TestDataFactory : AbstractDataFactory
    {
        public override CardActivityLog[] GetActivityLogData()
        {
            return new[]
            {
                new CardActivityLog
                {
                    Id = 100,
                    Action = "You created this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 20,
                },
                new CardActivityLog
                {
                    Id =  101,
                    Action = "You created this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 21,
                },
                new CardActivityLog
                {
                    Id = 102,
                    Action = "You created this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 22,
                },
                new CardActivityLog
                {
                    Id = 103,
                    Action = "You created this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 23,
                },
                new CardActivityLog
                {
                    Id = 104,
                    Action = "You created this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 24,
                },
                new CardActivityLog
                {
                    Id = 105,
                    Action = "You created this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 25,
                },
                new CardActivityLog
                {
                    Id = 106,
                    Action = "You created this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 26,
                },
                new CardActivityLog
                {
                    Id = 107,
                    Action = "You created this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 27,
                },
                new CardActivityLog
                {
                    Id = 108,
                    Action = "You created this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 28,
                },
                new CardActivityLog
                {
                    Id = 109,
                    Action = "You created this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 29,
                },
                new CardActivityLog
                {
                    Id = 110,
                    Action = "You renamed first card to first card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 20,
                },
                new CardActivityLog
                {
                    Id = 111,
                    Action = "You moved second card from To Do to Planned",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 21,
                },
                new CardActivityLog
                {
                    Id = 112,
                    Action = "You deleted third card from to do",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 22,
                },
                new CardActivityLog
                {
                    Id = 113,
                    Action = "You changed the priority fourth card from low to medium",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 23,
                },
                new CardActivityLog
                {
                    Id = 114,
                    Action = "You do something with this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 24,
                },
                new CardActivityLog
                {
                    Id = 115,
                    Action = "You do something with this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 25,
                },
                new CardActivityLog
                {
                    Id = 116,
                    Action = "You do something with this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 26,
                },
                new CardActivityLog
                {
                    Id = 117,
                    Action = "You do something with this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 27,
                },
                new CardActivityLog
                {
                    Id = 118,
                    Action = "You do something with this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 28,
                },
                new CardActivityLog
                {
                    Id = 119,
                    Action = "You do something with this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 29,
                },
                new CardActivityLog
                {
                    Id = 120,
                    Action = "You do something with this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 20,
                },
                new CardActivityLog
                {
                    Id = 121,
                    Action = "You do something with this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 21,
                },
                new CardActivityLog
                {
                    Id = 122,
                    Action = "You do something with this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 22,
                },
                new CardActivityLog
                {
                    Id = 123,
                    Action = "You do something with this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 23,
                },
                new CardActivityLog
                {
                    Id = 124,
                    Action = "You do something with this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 24,
                },
                new CardActivityLog
                {
                    Id = 125,
                    Action = "You do something with this card",
                    ActivityTime = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),
                    CardId = 25,
                },
            };
        }

        public override Board[] GetBoardData()
        {
            return new[]
            {
                new Board { Id = 20, Name = "testBoard" },
                new Board { Id = 21, Name = "secondTestBoard" }
            };
        }

        public override CardColumn[] GetCardColumnData()
        {
            return new[]
            {
                new CardColumn { Id = 20, Name = "first column", BoardId = 20 },
                new CardColumn { Id = 21, Name = "second column", BoardId = 20 }
            };
        }

        public override Card[] GetCardData()
        {
            return new[]
            {
                new Card { Id = 20, Name = "first card", Description = "some description for first card", DueDate = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 20, PriorityId = 1 },
                new Card { Id = 21, Name = "second card", Description = "some description for second card", DueDate = new DateTime(2025, 4, 12, 4, 13, 2, DateTimeKind.Utc),CardColumnId = 20, PriorityId = 2 },
                new Card { Id = 22, Name = "third card", Description = "some description for third card", DueDate = new DateTime(2024, 4, 3, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 20, PriorityId = 1 },
                new Card { Id = 23, Name = "fourth card", Description = "some description for fourth card", DueDate = new DateTime(2024, 1, 12, 12, 13, 2, DateTimeKind.Utc),CardColumnId = 20, PriorityId = 2 },
                new Card { Id = 24, Name = "fifth card", Description = "some description for fifth card", DueDate = new DateTime(2024, 4, 2, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 20 , PriorityId = 1},
                new Card { Id = 25, Name = "second column card", Description = "some description second column card", DueDate = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 21, PriorityId = 1},
                new Card { Id = 26, Name = "second column card2", Description = "some description second column card2", DueDate = new DateTime(2024, 4, 8, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 21, PriorityId = 3 },
                new Card { Id = 27, Name = "second column card3", Description = "some description second column card3", DueDate = new DateTime(2024, 4, 9, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 21 , PriorityId = 3},
                new Card { Id = 28, Name = "second column card4", Description = "some description for second column card4", DueDate = new DateTime(2024, 4, 11, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 21 , PriorityId = 3},
                new Card { Id = 29, Name = "second column card5", Description = "some description for second column card5", DueDate = new DateTime(2024, 4, 10, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 21 , PriorityId = 1}
            };
        }
        public override Priority[] GetPriorityData()
        {
            return new[]
            {
                new Priority{ Id = 1, Name = "Low"},
                new Priority{ Id = 2, Name = "Medium"},
                new Priority{ Id = 3, Name = "High"},
            };
        }


    }
}
