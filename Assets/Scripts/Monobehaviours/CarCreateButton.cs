using CarComponents;
using CarEvents;
using Interfaces;
using Scriptables;
using UnityEngine;
using UnityEngine.UI;

namespace Monobehaviours
{
    public class CarCreateButton : MonoBehaviour
    {
        public CarSpecifications Specifications;
        public Text ButtonName;
        public PlayerCar PlayerCar;
        public Shop Shop;

        private Button CreateButton;

        private void OnEnable()
        {
            if (CreateButton == null)
            {
                CreateButton = GetComponent<Button>();
            }
            CreateButton.onClick.AddListener(CreateCar);
        }

        private void OnDisable()
        {
            CreateButton.onClick.RemoveAllListeners();
        }

        private void Start()
        {
            ButtonName.text = $"{Specifications.Brand}";
        }

        private void CreateCar()
        {
            if (PlayerCar.CurrentPlayerCar != null)
            {
                Destroy(PlayerCar.CurrentPlayerCar);
            }

            EventManager.Events.InvokeCarCreateEvent(Specifications);

            PlayerCar.CurrentPlayerCar = FindObjectOfType<CarContainer>().gameObject;

            Shop.Buyable = PlayerCar.CurrentPlayerCar.GetComponent<IBuyable>();
            Shop.Customer = PlayerCar.GetComponent<ICustomer>();
        }
    }
}