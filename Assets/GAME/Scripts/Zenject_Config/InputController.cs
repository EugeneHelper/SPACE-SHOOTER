using GAME.Scripts.Signals;
using UnityEngine;
using Zenject;

namespace GAME.Scripts.Zenject_Config
{
    public class InputController : MonoBehaviour
    {
        private InputForMoveSignal _inputForMoveSignal;

        [Inject]
        public void Construct(InputForMoveSignal inputSignal)
        {
            _inputForMoveSignal = inputSignal;
        }

        void Update()
        {
            Vector3 inputDirection = GetInputDirection();
            _inputForMoveSignal.Invoke(inputDirection);
        }

        private Vector3 GetInputDirection()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            return new Vector3(horizontal, 0, vertical);
        }
    }
}