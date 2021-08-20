using Scriptables;

namespace EngineTypes
{
    public class EngineGas : Engine
    {
        public EngineGas(CarSpecifications carSpecifications, params IFuel[] fuels) : base(carSpecifications, fuels)
        {
        }
    }
}