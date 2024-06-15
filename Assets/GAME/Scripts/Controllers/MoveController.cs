using GAME.Scripts.Signals;
using UnityEngine;
using Zenject;

public class MoveController
{
    public void Move(ShipModel shipModel, ShipView shipView, Vector3 direction)
    {
        
        Debug.Log("I came to over " + GetType());

        Vector3 newPosition = shipModel.Position + direction * shipModel.Speed * Time.deltaTime;


        shipModel.UpdatePosition(newPosition);
        shipView.UpdatePosition(newPosition);
    }
}