using System;
namespace ObserverPattern
{
    public class CurrentTemperatureDisplay : IDisplay
    {

        private string Message;

        public void CalculateMessage(WeatherModel model)
        {
            Message = $"The current temperate is {model.Temperature} degrees";
        }

        public string GetMessage()
        {
            return Message;
        }
    }
}
