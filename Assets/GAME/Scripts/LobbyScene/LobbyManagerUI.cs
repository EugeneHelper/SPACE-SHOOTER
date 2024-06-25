using GAME.Scripts.LobbyScene;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class LobbyManagerUI : MonoBehaviour
{
    public Button[] shipButtons;

    private ShipSelecterController _shipController;
    private LobbySelectedShipInfoController _lobbySelectedShipInfoController;

    [Inject]
    public void Construct(ShipSelecterController shipController, LobbySelectedShipInfoController lobbySelectedShipInfoController)
    {
        _lobbySelectedShipInfoController = lobbySelectedShipInfoController;
        _shipController = shipController;
    }

    private void Start()
    {
        DisplayShipInfo();
        
        for (int i = 0; i < shipButtons.Length; i++)
        {
            int index = i;
            shipButtons[i].onClick.AddListener(() => OnShipButtonClicked((ShipType)index));
        }
    }

    private void OnShipButtonClicked(ShipType shipType)
    {
        _shipController.SelectShip(shipType);
        
        DisplayShipInfo();
    }

    private void DisplayShipInfo()
    {
        var selectedModel = _shipController.GetSelectedShip();
        _lobbySelectedShipInfoController.ShowShipInfo(selectedModel);
    }
}