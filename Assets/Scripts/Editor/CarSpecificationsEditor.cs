using Scriptables;
using System;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Editor
{
    [CustomEditor(typeof(CarSpecifications))]
    public class CarSpecificationsEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();


            if (GUILayout.Button("GeneratId"))
            {
                Generate();
            }
            EditorUtility.SetDirty(target);
        }

        public void Generate()
        {
            var carSpecifications = (CarSpecifications)target;
            if (carSpecifications.Id == "")
            {
                carSpecifications.Id = $"{Guid.NewGuid().ToString()}";
            }

            if (!Application.isPlaying)
            {
                EditorUtility.SetDirty(carSpecifications);
            }
        }

    }
}
