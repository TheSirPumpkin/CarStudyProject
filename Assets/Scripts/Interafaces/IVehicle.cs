using UnityEngine;

namespace Interfaces
{
    public interface IVehicle
    {
        bool IsMoving { get; }

        void Move();

        void Stop();

        Vector3 GetCurrentMovementVector { get; }
    }
}