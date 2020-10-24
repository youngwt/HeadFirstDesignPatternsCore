using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    /// <summary>
    /// The main data source for this project
    /// </summary>
    public class WeatherProvider : IObservable<WeatherModel>
    {
        /// <summary>
        /// The list of observers that need to know when this
        /// class's state changes
        /// </summary>
        private IList<IObserver<WeatherModel>> _observers;

        public WeatherProvider()
        {
            _observers = new List<IObserver<WeatherModel>>();
        }

        /// <summary>
        /// Tells all dependent observers that the state has changed
        /// Also passes the state along
        /// </summary>
        public void NotifyObservers(WeatherModel weatherModel)
        {
            foreach(IObserver<WeatherModel> observer in _observers)
            {
                observer.OnNext(weatherModel);
            }
        }

        /// <summary>
        /// Returns the number of subscribers currently registered
        /// </summary>
        /// <returns></returns>
        public int NumberOfSubscribers()
        {
            return _observers.Count;
        }

        /// <summary>
        /// Removes a subscriber
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(IObserver<WeatherModel> observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// Updates the state of the class and kicks off the notification process
        /// </summary>
        /// <param name="temp">The new temp</param>
        /// <param name="humidity">The new humidity</param>
        /// <param name="pressure">The new pressure</param>
        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            var weatherData = new WeatherModel
            {
                Temperature = temp,
                Humidity = humidity,
                Pressure = pressure
            };

            NotifyObservers(weatherData);
        }

        public IDisposable Subscribe(IObserver<WeatherModel> observer)
        {
            _observers.Add(observer);

            return new Unsubscriber(_observers, observer);
        }

        private class Unsubscriber : IDisposable
        {

            private IList<IObserver<WeatherModel>> _observers;

            private IObserver<WeatherModel> _observable;

            public Unsubscriber(IList<IObserver<WeatherModel>> observers, IObserver<WeatherModel> observer)
            {
                _observers = observers;
                _observable = observer;
            }


            public void Dispose()
            {
                _observers.Remove(_observable);
            }
        }
    }
}
