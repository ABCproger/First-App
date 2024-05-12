using First_App.Server.DataAccess.Helpers;
using First_App.Server.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockQueryable.Moq;
using System.Security.Cryptography.X509Certificates;
namespace First_App.Server.Tests
{
    public class PagedListTests
    {
        private readonly List<Card> _fakeCards;
        public PagedListTests()
        {
            _fakeCards = new List<Card>
            {
                new Card { Id = 1, Name = "Card 1", Description = "Description 1", DueDate = new DateTime(2024, 1, 1), CardColumnId = 1, PriorityId = 1 },
                new Card { Id = 2, Name = "Card 2", Description = "Description 2", DueDate = new DateTime(2024, 1, 2), CardColumnId = 1, PriorityId = 2 },
                new Card { Id = 3, Name = "Card 3", Description = "Description 3", DueDate = new DateTime(2024, 1, 3), CardColumnId = 2, PriorityId = 1 },
                new Card { Id = 4, Name = "Card 4", Description = "Description 4", DueDate = new DateTime(2024, 1, 4), CardColumnId = 2, PriorityId = 2 },
            };
        }
        [Fact]
        public async Task CreateAsync_Should_CreatePagedList()
        {
            // Arrange
            var queryableMock = _fakeCards.AsQueryable().BuildMock();
            var pageSize = 2;
            var page = 1;
            // Act
            var result = await PagedList<Card>.CreateAsync(queryableMock, page, pageSize);
            // Assert
            Assert.NotNull(result);
            Assert.Equal(page, result.Page);
            Assert.Equal(pageSize, result.PageSize);
            Assert.Equal(_fakeCards.Count, result.TotalCount);
            Assert.Equal(_fakeCards.Take(pageSize).ToList(), result.Items);
        }
    }
}
