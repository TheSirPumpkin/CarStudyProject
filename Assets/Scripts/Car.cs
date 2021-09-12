using Interfaces;
using Constants;
using EngineTypes;
using GameManagement;
using Scriptables;
using System;
using UnityEngine;
using static Enums.CarEnums;

namespace CarComponents
{
    [Serializable]
    public class Car : IVehicle // IBuyable removed, to use it as a component
    {
        public string Id { get; private set; }
        public Engine Engine { get; private set; }
        public int ReleaseYear { get; private set; }
        public bool EngineStarted { get; private set; }
        public float Weight { get; private set; }
        public int SittingPlaces { get; private set; }
        public bool IsMoving { get; set; }
        public CarType Type { get; private set; }
        public float FuelTankCapacity { get; private set; }

        public readonly CarBrand Brand;

        Vector3 IVehicle.GetCurrentMovementVector => throw new NotImplementedException();

        private CarEquipment equipment;
        private CarDrive drive;

        public Car(CarSpecifications specifications)
        {
            Id = specifications.Id;
            equipment = specifications.Equipment;
            Brand = specifications.Brand;
            drive = specifications.Drive;
            ReleaseYear = specifications.ReleaseYear;
            Weight = specifications.Weight;
            SittingPlaces = specifications.SittingPlaces;
            Engine = EngineFactory.GetEngine(specifications);
            Type = SetCarType();
            FuelTankCapacity = specifications.FuelTankCapacity;
        }

        public void EngineStart()
        {
            Engine.StartEngine();
        }

        public void Move()
        {
            if (EngineStarted)
            {
                // use CarMover class
            }
        }

        public void EngineStop()
        {
            EngineStarted = false;
        }

        public Vector3 GetCurrentMovementVector()
        {
            //Calculate current movement vector
            return Vector3.zero;
        }

        private CarType SetCarType()
        {
            if (Weight <= ProjectConstants.RoadCarWeightLimit && SittingPlaces <= ProjectConstants.RoadCarPlaceLimit && equipment == CarEquipment.Stock)
            {
                return CarType.Road;
            }
            else if (Weight > ProjectConstants.RoadCarWeightLimit && SittingPlaces <= ProjectConstants.RoadCarPlaceLimit && equipment == CarEquipment.Stock)
            {
                return CarType.Truck;
            }
            else if (SittingPlaces > ProjectConstants.RoadCarPlaceLimit && equipment == CarEquipment.Stock)
            {
                return CarType.Bus;
            }
            else if (equipment == CarEquipment.Racing)
            {
                return CarType.Race;
            }
            else
            {
                return CarType.Empty;
            }
        }

        public void Stop()
        {
        }
    }
}
