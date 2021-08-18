using Scriptables;

namespace EngineTypes
{
    public class EngineDiesel : Engine
    {
        public EngineDiesel(CarSpecifications carSpecifications, params IFuel[] fuels) : base(carSpecifications, fuels)
        {
        }
    }
}