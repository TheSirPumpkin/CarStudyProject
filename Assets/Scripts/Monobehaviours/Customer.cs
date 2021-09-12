using Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Monobehaviours
{
    public class Customer : MonoBehaviour, ICustomer
    {
        public float Money { get; set; }

        private void Start()
        {
            AddMoney(5000);
        }

        public void AddMoney(float amount)
        {
            Money += amount;
        }
    }
}
