using System;
using System.Collections;
using System.Collections.Generic;
using GAME.Scripts.Signals;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class SceneController : MonoBehaviour, IReciveSignal
{
    private ShipFlewToPlanetSignal _shipFlewToPlanetSignal;
    private TestSwitchToGameScene _testSwitchToGameScene;
    
    [Inject]
    public void Construct(ShipFlewToPlanetSignal shipFlewToPlanetSignal, TestSwitchToGameScene testSwitchToGameScene)
    {
        _shipFlewToPlanetSignal = shipFlewToPlanetSignal;
        _testSwitchToGameScene = testSwitchToGameScene;
    }

    void Start()
    {
        SubsribeTo();
    }

    private void SwitchScene(object[] objects)
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        switch (currentSceneIndex)
        {
            case 0:
                SceneManager.LoadScene(1);
                return;

            case 1:
                SceneManager.LoadScene(0);
                return;
        }
    }

    public void SubsribeTo()
    {
        _shipFlewToPlanetSignal.Subscribe(SwitchScene);
        _testSwitchToGameScene.Subscribe(SwitchScene);
    }

    public void UnSubscribeTo()
    {
        _shipFlewToPlanetSignal.Unsubscribe(SwitchScene);
        _testSwitchToGameScene.Unsubscribe(SwitchScene);

    }

    private void OnDestroy()
    {
        UnSubscribeTo();
    }
}