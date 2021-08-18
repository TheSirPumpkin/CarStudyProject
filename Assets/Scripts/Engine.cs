using Scriptables;
using System;
using UnityEngine;

namespace EngineTypes
{
    public abstract class Engine// <T:IFuel>
    {
        public IFuel[] Fuels;
        public float Power;
        public float FuelTankCapactiy;

        public Engine(CarSpecifications carSpecifications, params IFuel[] fuels)
        {
            this.FuelTankCapactiy = carSpecifications.FuelTankCapactiy;
            this.Power = carSpecifications.EnginePower;
            this.Fuels = fuels;
        }
        public virtual void StartEngine()
        {

        }
        public virtual void RunEngine()
        {

        }
        public virtual void StopEngine()
        {

        }

        public string GetFuelType()
        {
            string fuelType = "";
            foreach (var type in Fuels)
            {
                fuelType += " " + type.ToString();
            }
            return fuelType;
        }
    }
}
