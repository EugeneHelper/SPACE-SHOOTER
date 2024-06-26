using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class LobbySelectedShipInfoController : MonoBehaviour
{
    public RawImage _selectedShipImage;
    public TextMeshProUGUI selectedShipText;
    private ShipAbstrModel _selectedModel;



    public void ShowShipInfo(ShipAbstrModel selectedModel)
    {
        _selectedModel = selectedModel;
        ShowShipInfoText();
        SetSelectedShipImage();
    }
    
    private void ShowShipInfoText()
    {
        selectedShipText.text = $"Selected Ship: {_selectedModel.ShipName} " +
                                $"Health: {_selectedModel.ShipHealth}," +
                                $" Speed: {_selectedModel.ShipSpeed}";
    }

    private void SetSelectedShipImage()
    {
        _selectedShipImage.texture = _selectedModel.Texture;
    }
}
