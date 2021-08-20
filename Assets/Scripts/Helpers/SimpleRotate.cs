using UnityEngine;

namespace Helpers
{
    public class SimpleRotate : MonoBehaviour
    {
        public float xAngle, yAngle, zAngle;

        private void Update()
        {
            transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        }
    }
}