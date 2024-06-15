using UnityEngine;

public class ShipModel
{
    public Vector3 Position { get; private set; }
    private Vector3 Destination { get; set; }
    public float Speed { get; private set; }

    public ShipModel()
    {
        Position = Vector3.zero;
        Destination = new Vector3(0, 0, 100); // Точка Б
        Speed = 10f; // Скорость корабля
    }

    public void UpdatePosition(Vector3 newPosition)
    {
        Position = newPosition;
    }
}