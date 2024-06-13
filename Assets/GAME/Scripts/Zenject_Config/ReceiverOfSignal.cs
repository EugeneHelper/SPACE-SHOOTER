using System;
using GAME.Scripts.Signals;
using UnityEngine;
using Zenject;

public class ReceiverOfSignal : IInitializable, IDisposable
{
    readonly SignalBus _signalBus;

    public ReceiverOfSignal(SignalBus signalBus)
    {
        _signalBus = signalBus;
    }

    public void Initialize()
    {
        _signalBus.Subscribe<MoveShipSignal>(OnShipMove);
    }

    public void Dispose()
    {
        _signalBus.Unsubscribe<MoveShipSignal>(OnShipMove);
    }

    void OnShipMove(MoveShipSignal args)
    {
       // MoveShip(args._moveV3);
    }

    private void MoveShip(Vector3 v3)
    {
        Debug.Log("Moving for Vector3 =  " + v3 + "!");
    }
}
