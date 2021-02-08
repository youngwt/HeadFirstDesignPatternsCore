using System;
using Microsoft.Extensions.Logging;

namespace FactoryPattern
{
    /// <summary>
    /// A factory for creating different types of pizza
    /// </summary>
    public class SimplePizzaFactory : IPizzaFactory
    {
        /// <summary>
        /// Returns a pizza based on the provided type
        /// </summary>
        /// <param name="type">The type of piza requested</param>
        /// <returns>The pizza requested</returns>
        public IPizza CreatePizza(PizzaTypes type)
        {
            IPizza pizza = null;

            var loggerFactory = new LoggerFactory();

            switch(type)
            {
                case PizzaTypes.Margarita:
                    pizza = new MargaritaPizza(loggerFactory.CreateLogger<IPizza>());
                    break;
                case PizzaTypes.Pepperoni:
                    pizza = new PepperoniPizza(loggerFactory.CreateLogger<IPizza>());
                    break;
                default:
                    throw new ArgumentException();
            }

            return pizza;
        }
    }
}
