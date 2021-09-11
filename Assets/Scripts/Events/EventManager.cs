using Scriptables;
using UnityEngine;

namespace CarEvents
{
    public class EventManager
    {
        private static EventManager instance;
        public static EventManager Events => instance ?? (instance = new EventManager());

        public delegate GameObject CreateCar(CarSpecifications carSpecifications);

        public event CreateCar CarCreate;

        public GameObject InvokeCarCreateEvent(CarSpecifications carSpecifications)
        {
          return CarCreate?.Invoke(carSpecifications);
        }
    }
}