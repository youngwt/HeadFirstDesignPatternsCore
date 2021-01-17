using System;
namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public override string Description => "House Blend";

        public override double Cost => 0.89;
    }
}
