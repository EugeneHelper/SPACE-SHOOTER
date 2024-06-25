using UnityEngine;

public class SaveSelectedShipCommand
{
    public string ShipName { get; }
    public GameObject ShipPrefab { get; }
    public int Health { get; }
    public int Speed { get; }

    public SaveSelectedShipCommand(ShipAbstrModel ship)
    {
        ShipName = ship.ShipName;
        ShipPrefab = ship.ShipPrefab;
        Health = ship.ShipHealth;
        Speed = ship.ShipSpeed;
    }

    public void Execute()
    {
        GameState.SelectedShipName = ShipName;
        GameState.SelectedShipPrefab = ShipPrefab;
        GameState.SelectedShipHealth = Health;
        GameState.SelectedShipSpeed = Speed;
    }
}