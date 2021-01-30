using Microsoft.Extensions.Logging;

namespace FactoryPattern
{
    public class MargaritaPizza : IPizza
    {
        private readonly ILogger<IPizza> _logger;

        public MargaritaPizza(ILogger<IPizza> logger)
        {
            _logger = logger;
        }

        public string PizzaType => "Margarita";

        public ILogger<IPizza> Logger => _logger;
    }
}
