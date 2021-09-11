using Scriptables;

namespace EngineTypes
{
    public class EngineElectricity : Engine
    {
        public override IFuel[] Fuels { get ; set ; }

        public EngineElectricity(CarSpecifications carSpecifications, params IFuel[] fuels) : base(carSpecifications, fuels)
        {
        }
        public override void RunEngine()
        {
          
        }

        public override void StartEngine()
        {
            
        }

        public override void StopEngine()
        {
           
        }
    }
}