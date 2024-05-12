using First_App.Server.Controllers;
using First_App.Server.DataAccess.Data;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.DataAccess.Repositories;
using First_App.Server.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MockQueryable.Moq;
using Moq;

namespace First_App.Server.Tests
{
    public class CardRepositoryTests
    {
        private readonly List<Card> _fakeCardsList = new List<Card>
        {
            new Card{ Id = 20, Name = "first card", Description = "some description for first card", DueDate = new DateTime(2024, 4, 12, 2, 13, 2, DateTimeKind.Utc), CardColumnId = 20, PriorityId = 1 },
            new Card { Id = 21, Name = "second card", Description = "some description for second card", DueDate = new DateTime(2025, 4, 12, 4, 13, 2, DateTimeKind.Utc), CardColumnId = 20, PriorityId = 2 }
        };
        [Fact]
        public async Task AddAsync_Should_AddEntity()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "AddAsync_Should_AddEntity")
                .Options;

            using (var context = new ApplicationDbContext(options))
            {
                var cardRepository = new CardRepository(context);
                var newCard = new Card { Id = 1, Name = "New Card", Description = "New card description", DueDate = DateTime.UtcNow, CardColumnId = 1, PriorityId = 1 };

                // Act
                await cardRepository.AddAsync(newCard);

                // Assert
                var addedCard = await context.cards.FindAsync(1);
                Assert.NotNull(addedCard);
                Assert.Equal(newCard.Name, addedCard.Name);
                Assert.Equal(newCard.Description, addedCard.Description);
                Assert.Equal(newCard.DueDate, addedCard.DueDate);
                Assert.Equal(newCard.CardColumnId, addedCard.CardColumnId);
                Assert.Equal(newCard.PriorityId, addedCard.PriorityId);
            }
        }

        [Fact]
        public async Task DeleteByIdAsync_Should_ReturnFalse_WhenEntityIsNull()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "DeleteByIdDb_WhenEntityIsNull")
                .Options;
            using(var context = new ApplicationDbContext(options))
            {
                await context.cards.AddRangeAsync(_fakeCardsList);
                await context.SaveChangesAsync();
            }
            
            using(var context = new ApplicationDbContext(options))
            {
                var cardRepository = new CardRepository(context);
                // Act
                var result = await cardRepository.DeleteByIdAsync(0);
                // Assert
                Assert.False(result);
            }
        }
        [Fact]
        public async Task DeleteByIdAsync_Should_ReturnTrue_WhenEntityNotNull()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "DeleteByIdDb_WhenEntityNotNull")
                .Options;
            using (var context = new ApplicationDbContext(options))
            {
                await context.cards.AddRangeAsync(_fakeCardsList);
                await context.SaveChangesAsync();
            }

            using (var context = new ApplicationDbContext(options))
            {
                var cardRepository = new CardRepository(context);
                // Act
                var result = await cardRepository.DeleteByIdAsync(20);
                // Assert
                Assert.True(result);
            }
        }
        [Fact]
        public async Task DeleteByIdAsync_Should_DeleteEntity()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "DeleteByIdDb_Test")
                .Options;
            using (var context = new ApplicationDbContext(options))
            {
                await context.cards.AddRangeAsync(_fakeCardsList);
                await context.SaveChangesAsync();
            }
            using (var context = new ApplicationDbContext(options))
            {
                var cardRepository = new CardRepository(context);
                // Act
                await cardRepository.DeleteByIdAsync(20);
                var card = await context.cards.FindAsync(20);
                // Assert
                Assert.Null(card);
            }
        }
        [Fact]
        public async Task UpdateAsync_Should_ThrowArgumentNullException_WhenEntityIsNull()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "UpdateAsync_ThrowArgumentNullException_WhenEntityIsNull")
                .Options;
            var cardRepository = new CardRepository(new ApplicationDbContext(options));
            // Act & Assert
            await Assert.ThrowsAsync<ArgumentNullException>(() => cardRepository.UpdateAsync(null));
        }
        [Fact]
        public async Task UpdateAsync_Should_ReturnFalse_WhenEntityNotFound()
        {
            // Arrange
            int testCardId = 2;
            var testCard = new Card { Id = testCardId, Name = "second card Edit", Description = "some description for second card", DueDate = new DateTime(2025, 4, 12, 4, 13, 2, DateTimeKind.Utc), CardColumnId = 20, PriorityId = 2 };
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "UpdateAsync_ReturnFalse_WhenEntityNotFound")
                .Options;
            using (var context = new ApplicationDbContext(options))
            {
                await context.cards.AddRangeAsync(_fakeCardsList);
                await context.SaveChangesAsync();
            }
            using (var context = new ApplicationDbContext(options))
            {
                var cardRepository = new CardRepository(context);
                // Act
                var result = await cardRepository.UpdateAsync(testCard);
                // Assert
                Assert.False(result);
            }
        }
        [Fact]
        public async Task UpdateAsync_Should_ReturnTrue_WhenEntityUpdated()
        {
            // Arrange
            int testCardId = 20;
            var testCard = new Card { Id = testCardId, Name = "second card Edit", Description = "some description for second card", DueDate = new DateTime(2025, 4, 12, 4, 13, 2, DateTimeKind.Utc), CardColumnId = 20, PriorityId = 2 };
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "UpdateAsync_ReturnTrue_WhenEntityUpdated")
                .Options;
            using (var context = new ApplicationDbContext(options))
            {
                await context.cards.AddRangeAsync(_fakeCardsList);
                await context.SaveChangesAsync();
            }
            using (var context = new ApplicationDbContext(options))
            {
                var cardRepository = new CardRepository(context);
                // Act
                var result = await cardRepository.UpdateAsync(testCard);
                // Assert
                Assert.True(result);
            }
        }
    }
}