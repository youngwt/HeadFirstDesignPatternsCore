
namespace StrategyPattern
{
    /// <summary>
    /// Ducks fly and quack, but not all in the same way
    /// </summary>
    public abstract class Duck
    {
        public IFlyBehaviour FlyBehaviour { get; set; }
        public IQuackBehaviour QuackBehaviour { get; set; }

        public string Fly()
        {
            return FlyBehaviour.Fly();
        }

        public string Quack()
        {
            return QuackBehaviour.Quack();
        }
    }
}
