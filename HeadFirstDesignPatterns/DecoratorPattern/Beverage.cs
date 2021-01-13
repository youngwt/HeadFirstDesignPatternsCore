using System;

namespace DecoratorPattern
{
    abstract public class Beverage
    {
        string Description => "Unknown Beverage";

        public abstract double Cost();
    }
}
