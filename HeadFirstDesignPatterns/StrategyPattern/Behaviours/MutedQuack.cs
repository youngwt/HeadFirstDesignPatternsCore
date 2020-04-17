
namespace StrategyPattern.Behaviours
{
    /// <summary>
    /// Ducks with this behaviour are seen and not heard
    /// </summary>
    public class MutedQuack : IQuackBehaviour
    {
        public string Quack()
        {
            return "...";
        }
    }
}
