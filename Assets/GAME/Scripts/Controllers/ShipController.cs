using System.Collections;
using System.Collections.Generic;
using GAME.Scripts.Signals;
using UnityEngine;
using Zenject;

public class ShipController : MonoBehaviour, IReciveSignal
{
    private ShipModel _model;
    private ShipView _view;
    
    private InputForMoveSignal _inputForMoveSignal;


    [Inject]
    public void Construct(InputForMoveSignal inputForMoveSignal)
    {
        _model = new ShipModel();
        _view = GetComponent<ShipView>();
        _inputForMoveSignal = inputForMoveSignal;

        SubsribeTo();
    }


    private void OnMoveInputReceived(object[] args)
    {
        Vector3 direction = (Vector3) args[0];

        MoveCommand moveHorizontal = new MoveHorizontal(this.transform, direction, _model.Speed);
        moveHorizontal.Execute();
       
        _model.UpdatePosition(this.transform.position);
    }

    /// <summary>
    /// Subscribes
    /// </summary>
    public void SubsribeTo()
    {
        _inputForMoveSignal.Subscribe(OnMoveInputReceived);
    }

    public void UnSubscribeTo()
    {
        _inputForMoveSignal.Unsubscribe(OnMoveInputReceived);
    }


    private void OnDestroy()
    {
        UnSubscribeTo();
    }
}