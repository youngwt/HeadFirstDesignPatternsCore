using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    /// <summary>
    /// The main data source for this project
    /// </summary>
    public class WeatherData : ISubject
    {
        /// <summary>
        /// The list of observers that need to know when this
        /// class's state changes
        /// </summary>
        private IList<IObserver> _observers;

        // The state information for this class
        private float _temperature;
        private float _humidity;
        private float _pressure;

        /// <summary>
        /// Tells all dependent observers that the state has changed
        /// Also passes the state along
        /// </summary>
        public void NotifyObservers()
        {
            foreach(IObserver observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
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
        /// Adds a new subscriber
        /// </summary>
        /// <param name="observer">The subscriber to add</param>
        public void RegisterObserver(IObserver observer)
        {
            _observers = new List<IObserver>();
            _observers.Add(observer);
        }

        /// <summary>
        /// Removes a subscriber
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(IObserver observer)
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
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            NotifyObservers();
        }
    }
}
