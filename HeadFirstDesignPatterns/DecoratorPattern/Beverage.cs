using System;

namespace DecoratorPattern
{
    abstract public class Beverage
    {
        public abstract string Description { get; }

        public Beverage() {
        }

        public abstract double Cost { get; }

        public virtual double CalculateCost()
        {
            return Cost;
        }

        public virtual string GetDescription()
        {
            return Description;
        }

    }
}
