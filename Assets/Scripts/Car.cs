using CarInterfaces;
using Scriptables;
using UnityEngine;
using System;
using EngineTypes;
using static Enums.CarEnums;

//ADD NAMESPACE
[Serializable]
public class Car : IVehicle
{
    public int ReleaseYear { get; private set; }
    public bool EngineStarted { get; private set; }
    public bool BrandSet { get; private set; }
    public float Weight { get; private set; }
    public int SittingPlaces { get; private set; }
    public Engine Engine { get; private set; }
    public bool IsMoving { get; set; }
    public CarType Type { get; private set; }

    Vector3 IVehicle.GetCurrentMovementVector => throw new NotImplementedException();

    readonly private CarBrand brand;

    private CarEquipment equipment;
    private CarDrive drive;
   

    public Car(CarSpecifications specifications, Engine engine)
    {
        this.equipment = specifications.Equipment;
        this.brand = specifications.Brand;
        this.drive = specifications.Drive;
        this.ReleaseYear = specifications.ReleaseYear;
        this.Weight = specifications.Weight;
        this.SittingPlaces = specifications.SittingPlaces;
        this.Engine = engine;
        this.Type = SetCarType();
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
        if (Weight <= 3500 && SittingPlaces <= 8 && equipment == CarEquipment.Stock)//serialized for magic numbers
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
}
