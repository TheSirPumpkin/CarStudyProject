using EngineTypes;
using FuelTypes;
using Scriptables;
using static Enums.CarEnums;

namespace GameManagement
{
    public class EngineFactory : IFactory<IEngine>
    {
        public static Engine GetEngine(CarSpecifications specifications)
        {
            switch (specifications.EngineType)
            {
                case EngineType.Diesel:
                    return new EngineDiesel(specifications, new Diesel());

                case EngineType.Petrol:
                    return new EnginePetrol(specifications, new Petrol());

                case EngineType.Electricity:
                    return new EngineElectricity(specifications, new Electricity());

                case EngineType.Hybrid:
                    return new EngineHybrid(specifications, new Petrol(), new Electricity());

                case EngineType.Gas:
                    return new EngineGas(specifications, new Gas());

                default:
                    return new EnginePetrol(specifications, new Petrol());
            }
        }
    }
}

