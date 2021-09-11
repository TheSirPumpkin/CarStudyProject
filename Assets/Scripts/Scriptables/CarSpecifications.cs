using UnityEngine;

namespace Scriptables
{
    using static Enums.CarEnums;

    [CreateAssetMenu(fileName = "CarSpecifications", menuName = "CarData/CarSpecifications")]
    public class CarSpecifications : ScriptableObject
    {
        public CarEquipment Equipment;

        public CarBrand Brand;

        public CarDrive Drive;

        public EngineType EngineType;

        public float EnginePower;

        public float FuelTankCapactiy;

        public float Cost;

        public int ReleaseYear;

        public float Weight;

        public int SittingPlaces;

        public float FuelTankCapacity;

        public bool IsBuyable;

        public GameObject Prefab;
    }
}