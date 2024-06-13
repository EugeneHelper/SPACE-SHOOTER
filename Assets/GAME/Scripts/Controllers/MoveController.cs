using GAME.Scripts.Signals;
using UnityEngine;
using Zenject;

public class MoveController : MonoBehaviour, IReciveSignal
{
    private float _speed;
    //private MoveSignal _moveSignal;

    private MoveShipSignal _inputSignal;
    
    [Inject]
    public void Construct(MoveShipSignal inputSignal)
    {
        _inputSignal = inputSignal;
        
        SubsribeTo();
    }

    public void OnInputReceived(object[] args)
    {
        Vector3 vector = (Vector3) args[0];
        Debug.Log("I invoked signal" + vector);
       // Vector3 newPosition = transform.position + direction * _speed * Time.deltaTime;
       // _moveSignal.Fire(newPosition);
    }
    
    public void SubsribeTo()
    {
        _inputSignal.Subscribe(OnInputReceived);
    }
    
    public void UnSubscribeTo()
    {
        _inputSignal.Unsubscribe(OnInputReceived);
    }
    
    private void OnDestroy()
    {
        UnSubscribeTo();
    }
}
