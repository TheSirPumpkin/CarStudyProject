using System;
using CarEvents;
using EngineTypes;
using FuelTypes;
using Scriptables;
using UnityEngine;
using static Enums.CarEnums;

namespace Monobehaviours.GameManagement
{
    public class CarFabric : MonoBehaviour
    {
        public Vector3 SpawnPosition = default;
        public Transform CarParent = default;
        private GameObject currentCar = default;

        private void OnEnable()
        {
            EventManager.Events.CarCreate += CreateCar;
        }
        private void OnDestroy()
        {
            EventManager.Events.CarCreate -= CreateCar;
        }
        public void CreateCar(CarSpecifications specifications)
        {
            ClearCar();
            currentCar = Instantiate(specifications.Prefab, SpawnPosition, Quaternion.identity);
            ConstrcutCarComponents(specifications);
            currentCar.transform.parent = CarParent;
        }

        private void ConstrcutCarComponents(CarSpecifications specifications)
        {
            Engine carEngine = SetEngineType(specifications);

            currentCar.GetComponent<CarMonobehaviour>().Car = new Car(specifications, carEngine);
            currentCar.GetComponent<CarBuyableMonoBehaviour>().CarBuyable = new CarBuyable(specifications);
        }

        private static Engine SetEngineType(CarSpecifications specifications)
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

        private void ClearCar()
        {
            Destroy(currentCar?.gameObject);
            currentCar = default;
        }
    }
}
