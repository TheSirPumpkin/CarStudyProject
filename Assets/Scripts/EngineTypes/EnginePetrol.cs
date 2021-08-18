using Scriptables;

namespace EngineTypes
{
    public class EnginePetrol : Engine
    {
        public EnginePetrol(CarSpecifications carSpecifications, params IFuel[] fuels) : base(carSpecifications, fuels)
        {
        }
    }
}