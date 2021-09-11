using CarEvents;
using Scriptables;
using UnityEngine;
using UnityEngine.UI;

public class CarCreateButton : MonoBehaviour
{
    public CarSpecifications Specifications;
    public Text ButtonName;
    public PlayerCar PlayerCar;

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
        PlayerCar.CurrentPlayerCar = EventManager.Events.InvokeCarCreateEvent(Specifications);
    }
}