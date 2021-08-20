using CarInterfaces;
using Scriptables;
using System;

[Serializable]
public class CarBuyable : IBuyable //это вобще не нужно
{
    public float Cost { get; set; }

    public CarBuyable(CarSpecifications specifications)
    {
        Cost = specifications.Cost;
    }

    public void Buy(float money)
    {
    }
}