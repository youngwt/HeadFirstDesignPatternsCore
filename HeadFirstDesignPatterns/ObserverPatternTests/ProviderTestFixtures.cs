using NUnit.Framework;
using ObserverPattern;

namespace ObserverPatternTests
{
    public class ProviderTestFixtures
    {

        [Test]
        public void Can_Add_Observer()
        {
            // Arrange
            var provider = new WeatherProvider();

            // Act
            var subject = new WeatherObserver(provider, new CurrentTemperatureDisplay());

            // Assert
            Assert.That(provider.NumberOfSubscribers, Is.EqualTo(1));
        }

        [Test]
        public void Can_remove_Observer()
        {
            // Arrange
            var provider = new WeatherProvider();

            var subject = new WeatherObserver(provider, new CurrentTemperatureDisplay());

            // Act
            provider.RemoveObserver(subject);

            // Assert
            Assert.That(provider.NumberOfSubscribers, Is.EqualTo(0));
        }
    }
}