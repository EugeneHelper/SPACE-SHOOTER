using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using GAME.Scripts.Signals;
using UnityEngine;
using Zenject;

public class PlanetScript : MonoBehaviour
{
    private ShipFlewToPlanetSignal _shipFlewToPlanetSignal;
    
    [Inject]
    public void Construct(ShipFlewToPlanetSignal shipFlewToPlanetSignal)
    {
        _shipFlewToPlanetSignal = shipFlewToPlanetSignal;
    }
    private void OnTriggerEnter(Collider other)
    {
        _shipFlewToPlanetSignal.Invoke();
    }
}