using System;
namespace ObserverPattern
{
    public interface IDisplay
    {
        /// <summary>
        /// The action that the display component wil do when it is given data
        /// </summary>
        /// <param name="model">The input data</param>
        public void CalculateMessage(WeatherModel model);

        /// <summary>
        /// Returns a message from the display
        /// </summary>
        /// <returns></returns>
        public string GetMessage();
    }
}
