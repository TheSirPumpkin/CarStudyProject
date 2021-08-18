using System.Collections;
using System.Collections.Generic;
using EngineTypes;
using Scriptables;
using UnityEngine;

namespace Monobehaviours
{
    public class CarMonobehaviour : MonoBehaviour
    {
        public Car Car;

        private void Update()
        {
            Debug.Log("Current engine is: "+Car.Engine.ToString()+Car.Engine.GetFuelType());
            Debug.Log("Car type is: " + Car.Type.ToString());
        }

    }
}
