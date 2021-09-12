using CarComponents;
using CarEvents;
using GameManagement;
using Interfaces;
using Scriptables;
using UnityEngine;


namespace Monobehaviours.GameManagement
{
    public class CarFactory : MonoBehaviour, IFactory<IVehicle>
    {
        public Vector3 SpawnPosition = default;
        public Transform CarParent = default;

        private void OnEnable()
        {
            EventManager.Events.CarCreate += Create;
        }

        private void OnDestroy()
        {
            EventManager.Events.CarCreate -= Create;
        }

        public IVehicle Create(CarSpecifications specifications)
        {
            GameObject currentCar = Instantiate(specifications.Prefab, SpawnPosition, Quaternion.identity);

            IVehicle vehicle = new Car(specifications);

            currentCar.GetComponent<CarContainer>().Car = (Car)vehicle;

            currentCar.transform.parent = CarParent;

            if (specifications.IsBuyable)
            {
                currentCar.AddComponent<CarBuyable>();
                currentCar.GetComponent<CarBuyable>().Id = specifications.Id;

                if (SaveLoadData.BoughtItemsId.Contains(specifications.Id))
                {
                    currentCar.GetComponent<CarBuyable>().Bought = true;
                }
                currentCar.GetComponent<CarBuyable>().Cost = specifications.Cost;
            }

            return vehicle;
        }
    }
}