namespace FactoryPattern
{
    public interface IPizzaFactory
    {
        IPizza CreatePizza(PizzaTypes type);
    }
}
