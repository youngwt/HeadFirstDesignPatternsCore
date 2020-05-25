using Moq;
using NUnit.Framework;
using ObserverPattern;

namespace ObserverPatternTests
{
    public class SubjectTestFixtures
    {

        [Test]
        public void Can_Add_Observer()
        {
            // Arrange
            var mockObserver = new Mock<IObserver>();

            var subject = new WeatherData();

            // Act
            subject.RegisterObserver(mockObserver.Object);


            // Assert
            Assert.That(subject.NumberOfSubscribers, Is.EqualTo(1));
        }

        [Test]
        public void Can_remove_Observer()
        {
            // Arrange
            var mockObserver = new Mock<IObserver>();

            var subject = new WeatherData();
            subject.RegisterObserver(mockObserver.Object);

            // Act
            subject.RemoveObserver(mockObserver.Object);

            // Assert
            Assert.That(subject.NumberOfSubscribers, Is.EqualTo(0));
        }

        [Test]
        public void Can_notify_subscribers()
        {
            // Arrange
            var mockObserver = new Mock<IObserver>();

            var subject = new WeatherData();
            subject.RegisterObserver(mockObserver.Object);

            // Act

            subject.SetMeasurements(1, 2, 3);

            // Assert
            mockObserver.Verify(
                x => x.Update(1, 2, 3)
            );
        }
    }
}