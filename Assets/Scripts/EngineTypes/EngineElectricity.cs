using Scriptables;

namespace EngineTypes
{
    public class EngineElectricity : Engine
    {
        public EngineElectricity(CarSpecifications carSpecifications, params IFuel[] fuels) : base(carSpecifications, fuels)
        {
        }
    }
}
