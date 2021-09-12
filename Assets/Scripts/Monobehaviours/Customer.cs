using GameManagement;
using Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Monobehaviours
{
    public class Customer : MonoBehaviour, ICustomer, ILoadable, ISaveable
    {
        public float Money { get; set; }

        private void Start()
        {
            LoadData();
            AddMoney(5000);//temporary adding money, there are no other sources for money yet
        }

        public void AddMoney(float amount)
        {
            Money += amount;
            SaveData();
        }
        public void SaveData()
        {
            SaveLoadData.CustomerMoney = Money;
            SaveLoadData.SaveIntoJson();
        }
        public void LoadData()
        {
            Money = SaveLoadData.CustomerMoney;
        }

    }
}
