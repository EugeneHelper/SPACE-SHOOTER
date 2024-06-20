using GAME.Scripts.Signals;
using GAME.Scripts.Zenject_Config;
using Zenject;

public class GlobalInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //Signals (Don't use the same signal in the different SceneContext)
        Container.Bind<TestSwitchToGameScene>().AsSingle();
        Container.Bind<ShipFlewToPlanetSignal>().AsSingle();
        Container.Bind<InputForMoveSignal>().AsSingle();
        
        //Controllers
        Container.Bind<InputController>().FromComponentInHierarchy().AsSingle();
        Container.Bind<SceneController>().FromComponentInHierarchy().AsSingle();

    }
}
