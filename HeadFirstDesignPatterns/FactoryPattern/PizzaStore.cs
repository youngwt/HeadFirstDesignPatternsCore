using System;
namespace FactoryPattern
{
    public class PizzaStore
    {

        IPizzaFactory PizzaFactory { get; }

        public PizzaStore(IPizzaFactory pizzaFactory)
        {
            PizzaFactory = pizzaFactory;
        }

        public IPizza OrderPizza(PizzaTypes type)
        {
            var pizza = PizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Box();
            pizza.Cut();

            return pizza;
        }
    }
}
