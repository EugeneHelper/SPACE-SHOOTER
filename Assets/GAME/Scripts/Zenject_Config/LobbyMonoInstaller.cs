using System.Collections;
using System.Collections.Generic;
using GAME.Scripts.LobbyScene;
using UnityEngine;
using Zenject;

public class LobbyMonoInstaller : MonoInstaller
{

    public GameObject speedShip;
    public GameObject healthShip;
    public GameObject weaponShip;

    public override void InstallBindings()
    {
        Container.Bind<Dictionary<ShipType, ShipAbstrModel>>().FromInstance(CreateShipModels()).AsSingle();
        Container.Bind<ShipSelecterController>().AsSingle();
        Container.Bind<LobbySelectedShipInfoController>().FromComponentsInHierarchy().AsSingle();
    }

    private Dictionary<ShipType, ShipAbstrModel> CreateShipModels()
    {
        return new Dictionary<ShipType, ShipAbstrModel>
        {
            { ShipType.SpeedShip, speedShip.GetComponent<ShipAbstrModel>() },
            { ShipType.HealthShip, healthShip.GetComponent<ShipAbstrModel>() },
            { ShipType.WeaponShip, weaponShip.GetComponent<ShipAbstrModel>() }
        };
    }
}


