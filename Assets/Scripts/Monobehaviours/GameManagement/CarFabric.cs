using CarEvents;
using Scriptables;
using UnityEngine;


namespace Monobehaviours.GameManagement
{
    public class CarFabric : MonoBehaviour
    {
        public Vector3 SpawnPosition = default;
        public Transform CarParent = default;

        private void OnEnable()
        {
            EventManager.Events.CarCreate += CreateCar;
        }

        private void OnDestroy()
        {
            EventManager.Events.CarCreate -= CreateCar;
        }

        public GameObject CreateCar(CarSpecifications specifications)
        {
            GameObject currentCar = Instantiate(specifications.Prefab, SpawnPosition, Quaternion.identity);

            currentCar.GetComponent<CarContainer>().Car = new Car(specifications);

            currentCar.transform.parent = CarParent;

            return currentCar;
        }
    }
}