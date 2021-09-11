using Scriptables;

namespace EngineTypes
{
    public class EnginePetrol : Engine
    {
        public override IFuel[] Fuels { get; set; }
        public EnginePetrol(CarSpecifications carSpecifications, params IFuel[] fuels) : base(carSpecifications, fuels)
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