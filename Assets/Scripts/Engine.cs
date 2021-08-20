using System.Linq;
using Scriptables;

namespace EngineTypes
{
    public abstract class Engine : IEngine //все контракты вынести в интерфейс
    {
        public IFuel[] Fuels; //это должно быть свойством в наследниках, а здесь только абстрактно объявить
        public float Power; //мощность двигателя просто так не меняется, так что это должно быть свойство
        public float FuelTankCapacity; // количество топлива не относится к характеристикам двигателя, это должно быть в отдельной переменной в машине,
                                       // а сюда можешь просто инжектить ссылку на компонент который лежит в машине

        public Engine(CarSpecifications carSpecifications, params IFuel[] fuels)
        {
            FuelTankCapacity = carSpecifications.FuelTankCapactiy;
            Power = carSpecifications.EnginePower;
            Fuels = fuels;
        }

        public abstract void StartEngine();//в чем отличие Run и Start?

        public abstract void RunEngine();//в чем отличие Run и Start?

        public abstract void StopEngine();

        public string GetFuelType()
        {
            return Fuels.Aggregate("", (current, type) => current + (" " + type.ToString()));
        }
    }
}