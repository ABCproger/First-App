using First_App.Server.Entities;

namespace First_App.Server.DataAccess.Data.InitDataFactory
{
    public class TestDataFactory : AbstractDataFactory
    {
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
                new Card { Id = 20, Name = "first card", Description = "some description for first card", DueDate = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 20 },
                new Card { Id = 21, Name = "second card", Description = "some description for second card", DueDate = new DateTime(2025, 4, 12, 4, 13, 2, DateTimeKind.Utc),CardColumnId = 20 },
                new Card { Id = 22, Name = "third card", Description = "some description for third card", DueDate = new DateTime(2024, 4, 3, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 20 },
                new Card { Id = 23, Name = "fourth card", Description = "some description for fourth card", DueDate = new DateTime(2024, 1, 12, 12, 13, 2, DateTimeKind.Utc),CardColumnId = 20 },
                new Card { Id = 24, Name = "fifth card", Description = "some description for fifth card", DueDate = new DateTime(2024, 4, 2, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 20 },
                new Card { Id = 25, Name = "second column card", Description = "some description second column card", DueDate = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 21 },
                new Card { Id = 26, Name = "second column card2", Description = "some description second column card2", DueDate = new DateTime(2024, 4, 8, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 21 },
                new Card { Id = 27, Name = "second column card3", Description = "some description second column card3", DueDate = new DateTime(2024, 4, 9, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 21 },
                new Card { Id = 28, Name = "second column card4", Description = "some description for second column card4", DueDate = new DateTime(2024, 4, 11, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 21 },
                new Card { Id = 29, Name = "second column card5", Description = "some description for second column card5", DueDate = new DateTime(2024, 4, 10, 2, 13, 2, DateTimeKind.Utc),CardColumnId = 21 }
            };
        }


    }
}
