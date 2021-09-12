namespace Interfaces
{
    public interface IEngine
    {
        IFuel[] Fuels { get; set; }

        void StartEngine();

        void RunEngine();

        void StopEngine();

        string GetFuelType();
    }
}
