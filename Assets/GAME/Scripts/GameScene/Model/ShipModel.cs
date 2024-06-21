using System;
using UnityEngine;

public class ShipModel : ShipAbstrModel
{

    public void UpdatePosition(Vector3 newPosition)
    {
        Position = newPosition;
    }
}