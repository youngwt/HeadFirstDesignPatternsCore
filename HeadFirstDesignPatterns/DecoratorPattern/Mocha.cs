using System;
namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => "Mocha";

        public override double Cost => 0.2;
    }
}
