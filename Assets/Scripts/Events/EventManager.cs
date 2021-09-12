using Interfaces;
using Scriptables;
using UnityEngine;

namespace CarEvents
{
    public class EventManager
    {
        private static EventManager instance;
        public static EventManager Events => instance ?? (instance = new EventManager());

        public delegate IVehicle CreateCar(CarSpecifications carSpecifications);

        public event CreateCar CarCreate;

        public IVehicle InvokeCarCreateEvent(CarSpecifications carSpecifications)
        {
          return CarCreate?.Invoke(carSpecifications);
        }
    }
}