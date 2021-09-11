using System.Linq;
using Scriptables;

namespace EngineTypes
{
    public abstract class Engine : IEngine //все контракты вынести в интерфейс
    {
        public abstract IFuel[] Fuels { get; set; } 
        public float Power { get; set; }

        /// <summary>
        /// CarSpecifications is not replaced by EnginePower directly to provide posibility of adding additional params to engine using CarSpecifications
        /// </summary>
        public Engine(CarSpecifications carSpecifications, params IFuel[] fuels)
        {
            Power = carSpecifications.EnginePower;
            Fuels = fuels;
        }
        /// <summary>
        /// Engine startup
        /// </summary>
        public abstract void StartEngine();
        /// <summary>
        /// Engine workflow
        /// </summary>
        public abstract void RunEngine();

        public abstract void StopEngine();

        public string GetFuelType()
        {
            return Fuels.Aggregate("", (current, type) => current + (" " + type.ToString()));
        }
    }
}