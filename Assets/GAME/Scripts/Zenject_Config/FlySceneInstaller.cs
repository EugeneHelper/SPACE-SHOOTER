using GAME.Scripts.Signals;
using GAME.Scripts.Zenject_Config;
using Zenject;

public class FlySceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<MoveShipSignal>().AsSingle();
        Container.Bind<InputForMoveSignal>().AsSingle();

        // Регистрируем компоненты
        Container.Bind<InputController>().FromComponentInHierarchy().AsSingle();
        Container.Bind<ShipController>().FromComponentInHierarchy().AsSingle();
        
    }
}
