using UnityEngine;

public class ShipModel
{
    public Vector3 Position { get; private set; }
    public float Speed { get; private set; }

    public ShipModel()
    {
        Position = Vector3.zero;
        Speed = 50f; // Скорость корабля
    }

    public void UpdatePosition(Vector3 newPosition)
    {
        Position = newPosition;
    }
}