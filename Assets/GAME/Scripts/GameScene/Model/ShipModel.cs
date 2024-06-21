using UnityEngine;

public class ShipModel : IShipModel
{
    
    public string ShipName { get; set; }
    
    public GameObject ShipPrefab { get; set; }
    
    public int ShipHealth { get; set; }
    public int ShipSpeed { get; set; }
    private Vector3 Position { get; set; }

    public ShipModel()
    {
        Position = Vector3.zero;
        ShipSpeed = 50; // Скорость корабля
    }

    public void UpdatePosition(Vector3 newPosition)
    {
        Position = newPosition;
    }

}