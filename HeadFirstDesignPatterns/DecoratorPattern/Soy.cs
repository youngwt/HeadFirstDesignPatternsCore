using System;
namespace DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => "Soy";

        public override double Cost => 0.15;
    }
}
