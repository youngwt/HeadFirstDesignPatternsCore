using System;
using NUnit.Framework;
using ObserverPattern;

namespace ObserverPatternTests
{
    [TestFixture]
    public class WeatherObserverTests
    {
        private WeatherObserver _currentWeatherObserver;
        private WeatherObserver _weatherSummaryObserver;
        private WeatherProvider _weatherProvider;

        [SetUp]
        public void Setup()
        {
            _weatherProvider = new WeatherProvider();
            _currentWeatherObserver = new WeatherObserver(_weatherProvider, new CurrentTemperatureDisplay());
            _weatherSummaryObserver = new WeatherObserver(_weatherProvider, new WeatherSummaryDisplay());

        }

        [TestCase]
        public void UpdatingDataPushesToAllSubscribers()
        {
            // Arrange
            var model = new WeatherModel()
            {
                Humidity = 90,
                Pressure = 1,
                Temperature = 21
            };

            // Act
            _weatherProvider.SetMeasurements(model.Temperature, model.Humidity, model.Humidity);

            // Assert
            Assert.That(_currentWeatherObserver.Display.GetMessage(), Is.EqualTo("The current temperate is 21 degrees"));
            Assert.That(_weatherSummaryObserver.Display.GetMessage(), Is.EqualTo("The weather is nice"));
        }

        [TestCase]
        public void ObserverCanUnsubscribeItself()
        {
            // Act
            _currentWeatherObserver.Unsubscribe();

            // Assert
            Assert.That(_weatherProvider.NumberOfSubscribers, Is.EqualTo(1));

        }
    }
}
