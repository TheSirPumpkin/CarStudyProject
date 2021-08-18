using Scriptables;

namespace CarEvents
{
    public class EventManager
    {
        private static EventManager instance;
        public static EventManager Events => instance ?? (instance = new EventManager());

        public delegate void CreateCar(CarSpecifications carSpecifications);
        public event CreateCar CarCreate;

        public void InvokeCarCreateEvent(CarSpecifications carSpecifications)
        {
            CarCreate?.Invoke(carSpecifications);
        }
    }
}
