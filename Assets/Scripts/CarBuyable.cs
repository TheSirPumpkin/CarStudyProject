using CarInterfaces;
using Scriptables;
using System;
using UnityEngine;
/// <summary>
/// Moved to a separate class to provide versatility e.g. if we dont want an object to be byable we just dont add this script to it
/// </summary>
[Serializable]
public class CarBuyable : MonoBehaviour, IBuyable
{
    public float Cost { get; set; }

    public CarBuyable(CarSpecifications specifications)
    {
        Cost = specifications.Cost;
    }

    public void Buy(float money)// transfer to shop class But(Customer :ICustomer c, Ibuyable)
    {
    }
}