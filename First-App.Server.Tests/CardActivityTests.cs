using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using First_App.Server.Observers.Interfaces;
using First_App.Server.Observers;
using Moq;
using Xunit;

namespace First_App.Server.Tests
{
    

    public class CardActivityTests
    {
        [Fact]
        public async Task NotifyAsync_Should_NotifyObservers()
        {
            // Arrange
            var mockObserver1 = new Mock<IObserver>();
            var mockObserver2 = new Mock<IObserver>();

            var activity = new CardActivity();
            await activity.AttachAsync(mockObserver1.Object);
            await activity.AttachAsync(mockObserver2.Object);

            // Act
            await activity.NotifyAsync("create", 1);

            // Assert
            mockObserver1.Verify(
                observer => observer.UpdateAsync(It.IsAny<ICardActivity>(), "create", 1),
                Times.Once);
            mockObserver2.Verify(
                observer => observer.UpdateAsync(It.IsAny<ICardActivity>(), "create", 1),
                Times.Once);
        }

        [Fact]
        public async Task NotifyAsync_Should_NotNotifyDetachedObserver()
        {
            // Arrange
            var mockObserver = new Mock<IObserver>();

            var activity = new CardActivity();
            await activity.AttachAsync(mockObserver.Object);
            await activity.DetachAsync(mockObserver.Object);

            // Act
            await activity.NotifyAsync("create", 1);

            // Assert
            mockObserver.Verify(
                observer => observer.UpdateAsync(It.IsAny<ICardActivity>(), It.IsAny<string>(), It.IsAny<int>()),
                Times.Never);
        }
    }

}
