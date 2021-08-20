namespace Enums
{
    public static class CarEnums
    {
        public enum CarEquipment
        {
            Stock,
            Racing
        };

        public enum CarType
        {
            Empty,
            Road,
            Race,
            Truck,
            Bus
        };

        public enum CarBrand
        {
            Ferrari,
            Lancia,
            Mercedes,
            Audi,
            BMW,
            Volkswagen
        };

        public enum CarDrive
        {
            Full,
            Front,
            Rear
        };

        public enum EngineType
        {
            Empty,
            Diesel,
            Petrol,
            Electricity,
            Gas,
            Hybrid//IsHybrid dinside engine, remove from here
        };
    }
}