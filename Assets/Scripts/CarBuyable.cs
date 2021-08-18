using CarInterfaces;
using Scriptables;
using System;
using UnityEngine;

[Serializable]
public class CarBuyable : IBuyable
{
    public float Cost { get; set; }
    public CarBuyable(CarSpecifications specifications)
    {
        this.Cost = specifications.Cost;
    }
    public void Buy(float money)
    {

    }
}
