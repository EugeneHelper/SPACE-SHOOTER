using System.Collections;
using System.Collections.Generic;
using GAME.Scripts.Signals;
using UnityEngine;
using Zenject;

public class ShipController : MonoBehaviour, IReciveSignal
{
    private ShipModel _model;
    private ShipView _view;

    private MoveShipSignal _moveShipSignal;

    [Inject]
    public void Construct(MoveShipSignal moveSignal)
    {
        _model = new ShipModel();
        _view = GetComponent<ShipView>();
        _moveShipSignal = moveSignal;

        SubsribeTo();
    }
    

    private void OnMoveReceived(object[] args)
    {
        Vector3 v3 = (Vector3) args[0];
        // _model.UpdatePosition(v3);
        // _view.UpdatePosition(v3);
    }
    
/// <summary>
/// Subscribes
/// </summary>
    public void SubsribeTo()
    {
        _moveShipSignal.Subscribe(OnMoveReceived);
    }

    public void UnSubscribeTo()
    {
        _moveShipSignal.Unsubscribe(OnMoveReceived);
    }
    
    private void OnDestroy()
    {
        UnSubscribeTo();
    }
}