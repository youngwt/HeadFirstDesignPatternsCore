using System;
namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        internal Beverage Beverage { get; }

        public CondimentDecorator(Beverage beverage) : base()
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{Beverage.GetDescription()}, {this.Description}";
        }

        public override double CalculateCost()
        {
            return Beverage.CalculateCost() + Cost;
        } 
    }
}
