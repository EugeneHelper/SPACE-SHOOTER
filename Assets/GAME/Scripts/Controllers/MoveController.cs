using GAME.Scripts.Signals;
using UnityEngine;
using Zenject;

public class MoveController : MonoBehaviour, IReciveSignal
{
    private float _speed;
    //private MoveSignal _moveSignal;

    private InputForMoveSignal _inputForMoveSignal;
    private MoveShipSignal _moveShipSignal;

    [Inject]
    public void Construct(InputForMoveSignal inputSignal, MoveShipSignal moveShipSignal)
    {
        _inputForMoveSignal = inputSignal;
        _moveShipSignal = moveShipSignal;

        SubsribeTo();
    }

    public void OnInputReceived(object[] args)
    {
        Debug.Log(GetType());
        Vector3 directionOfMove = (Vector3) args[0];

        
        Vector3 newPosition = transform.position + directionOfMove * _speed * Time.deltaTime;
        _moveShipSignal.Invoke(newPosition);
    }

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