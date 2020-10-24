using System;
namespace ObserverPattern
{
    public class WeatherObserver : IObserver<WeatherModel>
    {
        /// <summary>
        /// A reference to the subscriber - is initialised in the ctor
        /// </summary>
        private IDisposable _unsubscriber;

        /// <summary>
        /// A module that give some kind of output
        /// </summary>
        public IDisplay Display {get;}

        public WeatherObserver(IObservable<WeatherModel> subscriber, IDisplay display)
        {
            _unsubscriber = subscriber.Subscribe(this);
            Display = display;
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherModel value)
        {
            Display.CalculateMessage(value);
        }

        public void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }
    }
}
