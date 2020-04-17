namespace StrategyPattern.Behaviours
{
    /// <summary>
    /// Ducks with this behaviour fly normally
    /// </summary>
    public class FlyWithWings : IFlyBehaviour
    {
        public string Fly()
        {
            return "Flying with wings";
        }
    }
}
