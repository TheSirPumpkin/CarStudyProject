using System;
using UnityEngine;
using static Enums.CarEnums;

namespace Scriptables
{
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

        public GameObject Prefab;
      
    }
}
