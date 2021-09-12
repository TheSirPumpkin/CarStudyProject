using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameManagement
{
    public static class SaveLoadData
    {
        public static List<string> BoughtItemsId = new List<string>();
        public static float CustomerMoney;


        public static void SaveIntoJson()
        {
            Data serializableData = new Data
            {
                serializableBoughtItemsId = BoughtItemsId.ToArray(),
                serializableCustomerMoney = CustomerMoney
            };

            string data = JsonUtility.ToJson(serializableData);
            System.IO.File.WriteAllText(Application.persistentDataPath + "/SaveData.json", data);
        }

        public static void ReadFromJson()
        {
            Data serializableData = JsonUtility.FromJson<Data>(System.IO.File.ReadAllText(Application.persistentDataPath + "/SaveData.json"));
            
            if (serializableData.serializableBoughtItemsId != null && serializableData.serializableBoughtItemsId.Length > 0)
            {
                foreach (var id in serializableData.serializableBoughtItemsId)
                {
                    BoughtItemsId.Add(id);
                }
            }
            CustomerMoney = serializableData.serializableCustomerMoney;
        }

        [Serializable]
        private struct Data
        {
            public string[] serializableBoughtItemsId;
            public float serializableCustomerMoney;
        }
    }
}
