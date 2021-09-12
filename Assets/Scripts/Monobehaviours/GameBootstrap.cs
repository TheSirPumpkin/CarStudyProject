using GameManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Monobehaviours.GameManagement
{
    public class GameBootstrap : MonoBehaviour
    {
        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            SaveLoadData.ReadFromJson();
        }
    }
}