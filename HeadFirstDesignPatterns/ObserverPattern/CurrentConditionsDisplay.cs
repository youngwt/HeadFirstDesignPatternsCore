using System;
namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        /// <summary>
        /// A reference to the subscriber - is initialised in the ctor
        /// </summary>
        private ISubject _weatherData;

        /// <summary>
        /// The temperature
        /// </summary>
        private float _temperature;

        /// <summary>
        /// The humidity
        /// </summary>
        private float _humidity;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"The current temperature is {_temperature}");
            Console.WriteLine($"The current air pressure is {_humidity}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
