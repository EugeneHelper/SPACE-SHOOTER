using UnityEngine;
using UnityEngine.UI;

public class SaveSelectedShipCommand
{
    public string ShipName { get; }
    public GameObject ShipPrefab { get; }
    
    public Texture ShipImage { get; }
    public int Health { get; }
    public int Speed { get; }

    public SaveSelectedShipCommand(ShipAbstrModel ship)
    {
        ShipName = ship.ShipName;
        ShipPrefab = ship.ShipPrefab;
        ShipImage = ship.Texture;
        Health = ship.ShipHealth;
        Speed = ship.ShipSpeed;
    }

    public void Execute()
    {
        GameState.SelectedShipName = ShipName;
        GameState.SelectedShipPrefab = ShipPrefab;
        GameState.ShipImage = ShipImage;
        GameState.SelectedShipHealth = Health;
        GameState.SelectedShipSpeed = Speed;
    }
}