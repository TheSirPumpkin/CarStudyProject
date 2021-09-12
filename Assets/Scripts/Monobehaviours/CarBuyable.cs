using Interfaces;
using Scriptables;
using System;
using UnityEngine;

namespace Monobehaviours
{
    /// <summary>
    /// Moved to a separate class to provide versatility e.g. if we dont want an object to be byable we just dont add this script to it
    /// </summary>
    [Serializable]
    public class CarBuyable : MonoBehaviour, IBuyable
    {
        public string Id { get; set; }
        public float Cost { get; set; }
        public bool Bought { get; set; }
    }
}