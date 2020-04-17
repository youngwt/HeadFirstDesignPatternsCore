using System;
namespace StrategyPattern.Behaviours
{
    /// <summary>
    /// Ducks with this bevariour quack like a duck
    /// </summary>
    public class NormalQuack : IQuackBehaviour
    {
        public NormalQuack()
        {
        }

        public string Quack()
        {
            return "Quack!";
        }
    }
}
