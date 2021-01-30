using Microsoft.Extensions.Logging;

namespace FactoryPattern
{
    public class PepperoniPizza : IPizza
    {
        private readonly ILogger<IPizza> _logger;

        public PepperoniPizza(ILogger<IPizza> logger)
        {
            _logger = logger;
        }

        public string PizzaType => "Pepperoni";

        public ILogger<IPizza> Logger => _logger;
    }
}
