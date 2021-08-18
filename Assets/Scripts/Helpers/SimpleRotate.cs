using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Helpers
{
    public class SimpleRotate : MonoBehaviour
    {
        public float xAngle, yAngle, zAngle;

        void Update()
        {
            transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        }
    }
}
