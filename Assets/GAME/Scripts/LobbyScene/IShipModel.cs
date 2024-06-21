using UnityEngine;

public interface IShipModel
{
    string ShipName { get; set; }
    GameObject ShipPrefab { get; set; }
    int ShipHealth { get; set; }
    int ShipSpeed { get; set; }
}