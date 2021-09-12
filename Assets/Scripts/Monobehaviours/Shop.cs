using Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Monobehaviours
{
    public class Shop : MonoBehaviour, IShop
    {
        public ICustomer Customer { get; set; }
        public Button BuyButton;

        private IBuyable buyable;
        public IBuyable Buyable
        {
            get
            {
                return buyable;
            }
            set
            {
                buyable = value;
                if (buyable != null)
                {
                    SetBuyButtonState(!buyable.Bought);
                }
                else
                {
                    SetBuyButtonState(false);

                }
            }
        }
        private void Start()
        {
            SetBuyButtonState(false);
            BuyButton.onClick.AddListener(Buy);
        }
        public void Buy()
        {
            if (Buyable?.Cost <= Customer?.Money)
            {
                Customer.Money -= Buyable.Cost;
                Buyable.Bought = true;
                SetBuyButtonState(false);

                //SaveData.BuyableId=Buyable.Id
                //SaveData.Save();
            }
        }
        private void SetBuyButtonState(bool state)
        {
            BuyButton.gameObject.SetActive(state);
        }
    }
}
