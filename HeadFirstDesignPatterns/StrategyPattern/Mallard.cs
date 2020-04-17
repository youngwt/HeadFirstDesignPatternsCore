
using StrategyPattern.Behaviours;

namespace StrategyPattern
{
    public class Mallard : Duck
    {
        public Mallard()
        {
            QuackBehaviour = new NormalQuack();
            FlyBehaviour = new FlyWithWings();
        }
    }
}
