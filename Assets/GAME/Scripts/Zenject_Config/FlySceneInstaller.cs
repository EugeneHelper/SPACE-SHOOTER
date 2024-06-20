using GAME.Scripts.Signals;
using GAME.Scripts.Zenject_Config;
using Zenject;

public class FlySceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
       // Container.Bind<InputForMoveSignal>().AsSingle();

        // Регистрируем компоненты
        Container.Bind<ShipController>().FromComponentInHierarchy().AsSingle();
        
    }
}
