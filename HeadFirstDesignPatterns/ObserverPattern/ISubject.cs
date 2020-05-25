using System;
namespace ObserverPattern
{
    public interface ISubject
    {
        /// <summary>
        /// Adds a new observer to the subject's list
        /// </summary>
        /// <param name="observer">The new observer</param>
        public void RegisterObserver(IObserver observer);

        /// <summary>
        /// Removes the observer from the list
        /// </summary>
        /// <param name="observer">The observer to remove</param>
        public void RemoveObserver(IObserver observer);

        /// <summary>
        /// Tells all observers that the state has changed
        /// </summary>
        public void NotifyObservers();

        /// <summary>
        /// Returns the number of subscribers
        /// </summary>
        public int NumberOfSubscribers();
    }
}
