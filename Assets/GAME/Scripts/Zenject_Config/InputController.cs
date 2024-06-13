using GAME.Scripts.Signals;
using UnityEngine;
using Zenject;

namespace GAME.Scripts.Zenject_Config
{
    public class InputController : MonoBehaviour
    {
        private MoveShipSignal _inputSignal;

        [Inject]
        public void Construct(MoveShipSignal inputSignal)
        {
            _inputSignal = inputSignal;
        }

        void Update()
        {
            Vector3 inputDirection = GetInputDirection();
            _inputSignal.Invoke(inputDirection);
        }

        private Vector3 GetInputDirection()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            return new Vector3(horizontal, 0, vertical);
        }
    }
}