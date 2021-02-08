using FactoryPattern;
using NUnit.Framework;

namespace FactoryPatternTests
{
    public class FactoryPatternTests
    {
        [TestCase(PizzaTypes.Margarita)]
        [TestCase(PizzaTypes.Pepperoni)]
        public void SimplePizzaFactory_Can_create_pizzas(PizzaTypes type)
        {
            // Arrange

            var simpleFactory = new SimplePizzaFactory();

            // Act
            var pizza = simpleFactory.CreatePizza(type);

            // Assert
            Assert.That(pizza, Is.Not.Null);
            Assert.That(pizza.PizzaType, Is.EqualTo(type.ToString()));
        }

        [TestCase(PizzaTypes.Margarita)]
        [TestCase(PizzaTypes.Pepperoni)]
        public void PizzaStore_Can_order_pizzas(PizzaTypes type)
        {
            // Arrange

            var simpleFactory = new SimplePizzaFactory();
            var pizzaStore = new PizzaStore(simpleFactory);

            // Act
            var pizza = pizzaStore.OrderPizza(type);

            // Assert
            Assert.That(pizza, Is.Not.Null);
            Assert.That(pizza.PizzaType, Is.EqualTo(type.ToString()));
        }
    }
}