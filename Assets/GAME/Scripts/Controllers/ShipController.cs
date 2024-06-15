using System.Collections;
using System.Collections.Generic;
using GAME.Scripts.Signals;
using UnityEngine;
using Zenject;

public class ShipController : MonoBehaviour, IReciveSignal
{
    private ShipModel _model;
    private ShipView _view;
    
    private MoveController _moveController;

    private InputForMoveSignal _inputForMoveSignal;


    [Inject]
    public void Construct
    (
        MoveController moveController,
        InputForMoveSignal inputForMoveSignal
    )
    {
        _model = new ShipModel();
        _view = GetComponent<ShipView>();

        _moveController = moveController;
        _inputForMoveSignal = inputForMoveSignal;

        SubsribeTo();
    }


    private void OnInputReceived(object[] args)
    {
        Vector3 direction = (Vector3) args[0];
        _moveController.Move(_model, _view, direction);
    }

    /// <summary>
    /// Subscribes
    /// </summary>
    public void SubsribeTo()
    {
        _inputForMoveSignal.Subscribe(OnInputReceived);
    }

    public void UnSubscribeTo()
    {
        _inputForMoveSignal.Unsubscribe(OnInputReceived);
    }


    private void OnDestroy()
    {
        UnSubscribeTo();
    }
}