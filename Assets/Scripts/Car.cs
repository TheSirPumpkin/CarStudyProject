using CarInterfaces;
using EngineTypes;
using Scriptables;
using System;
using UnityEngine;
using static Enums.CarEnums;

//ADD NAMESPACE
[Serializable]
public class Car : IVehicle, IBuyable //интерфейс "покупаемый" стоит добавить прямо сюда
{
    public Engine Engine { get; private set; }
    public int ReleaseYear { get; private set; }
    public bool EngineStarted { get; private set; }
    public float Weight { get; private set; }
    public int SittingPlaces { get; private set; }
    public bool IsMoving { get; set; }
    public CarType Type { get; private set; }

    public readonly CarBrand Brand;

    Vector3 IVehicle.GetCurrentMovementVector => throw new NotImplementedException();

    private CarEquipment equipment;
    private CarDrive drive;

    public Car(CarSpecifications specifications)
    {
        equipment = specifications.Equipment;
        Brand = specifications.Brand;
        drive = specifications.Drive;
        ReleaseYear = specifications.ReleaseYear;
        Weight = specifications.Weight;
        SittingPlaces = specifications.SittingPlaces;
        Engine = EngineFactory.GetEngine(specifications.EngineType); //двигатель должен получаться с фабрики
        Type = SetCarType();
    }

    public class EngineFactory : IFactory<IEngine> //примерно то как должна выглядеть фабрика, только нужно перенести все в отдельный класс
    {
        public static Engine GetEngine(EngineType specificationsEngineType)
        {
            throw new NotImplementedException();
        }
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
        if (Weight <= 3500 && SittingPlaces <= 8 && equipment == CarEquipment.Stock) //serialized for magic numbers
        {
            return CarType.Road;
        }
        else if (Weight > 3500 && SittingPlaces <= 8 && equipment == CarEquipment.Stock)
        {
            return CarType.Truck;
        }
        else if (SittingPlaces > 8 && equipment == CarEquipment.Stock)
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
    public float Cost { get; set; }
    public void Buy(float money)
    {
        throw new NotImplementedException();
    }
}
public interface IEngine
{
}
public interface IFactory<T>
{
}