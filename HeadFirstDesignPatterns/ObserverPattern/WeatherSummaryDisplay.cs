using System;
namespace ObserverPattern
{
    public class WeatherSummaryDisplay : IDisplay
    {

        private string Message;

        public void CalculateMessage(WeatherModel model)
        {
            if(model.Temperature < 10 )
            {
                Message = "The weather is cold";
            } else if(model.Temperature < 20)
            {
                Message = "The weather is cool";
            } else if(model.Temperature < 30)
            {
                Message = "The weather is nice";
            } else
            {
                Message = "The weather is hot";
            }
        }

        public string GetMessage()
        {
            return Message;
        }
    }
}
