using UnityEngine;

namespace CarInterfaces
{
    public interface IVehicle
    {
        bool IsMoving { get; }

        void Move();

        void Stop();

        Vector3 GetCurrentMovementVector { get; }
    }
}