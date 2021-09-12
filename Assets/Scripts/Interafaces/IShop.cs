using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interfaces
{
    public interface IShop
    {
        IBuyable Buyable { get; set; }
        ICustomer Customer { get; set; }
        void Buy();// transfer to shop class But(Customer :ICustomer c, Ibuyable)
    }
}
