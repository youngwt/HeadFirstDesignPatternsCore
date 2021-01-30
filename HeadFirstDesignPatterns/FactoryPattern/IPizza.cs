
using Microsoft.Extensions.Logging;

namespace FactoryPattern
{
    /// <summary>
    /// Base class for different types of pizza
    /// </summary>
    public interface IPizza
    {
        public string PizzaType { get; }
        public ILogger<IPizza> Logger { get; }

        public virtual void Prepare()
        {
            Logger.LogInformation($"Preparing a {PizzaType} pizza");
        }

        public virtual void Bake()
        {
            Logger.LogInformation("Baking the pizza");
        }

        public virtual void Cut()
        {
            Logger.LogInformation("Cutting pizza");
        }

        public virtual void Box()
        {
            Logger.LogInformation("Boxing pizza");
        }
    }
}
