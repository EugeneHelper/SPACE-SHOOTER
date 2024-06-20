using System;
using GAME.Scripts.Signals;
using UnityEngine;
using Zenject;

namespace GAME.Scripts.Zenject_Config
{
    public class InputController : MonoBehaviour
    {
        private InputForMoveSignal _inputForMoveSignal;
        private TestSwitchToGameScene _testSwitchToGameScene;

        [Inject]
        public void Construct(InputForMoveSignal inputSignal, TestSwitchToGameScene testSwitchToGameScene)
        {
            _inputForMoveSignal = inputSignal;
            _testSwitchToGameScene = testSwitchToGameScene;
        }

        void Update()
        {
            HandleMoveInput();

            TestSwithScene();
        }

        private void TestSwithScene()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log(this + "TestMethod");
                _testSwitchToGameScene.Invoke();
            }
        }

        private void HandleMoveInput()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            if (horizontal != 0 || vertical != 0)
            {
                Vector3 inputDirection = new Vector3(horizontal, 0, vertical);
                _inputForMoveSignal.Invoke(inputDirection);
            }
        }
    }
}