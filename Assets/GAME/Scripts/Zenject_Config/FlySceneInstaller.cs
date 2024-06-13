using GAME.Scripts.Signals;
using GAME.Scripts.Zenject_Config;
using Zenject;

public class FlySceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<MoveShipSignal>().AsSingle();
        
        
        // Регистрируем компоненты
        Container.Bind<InputController>().FromComponentInHierarchy().AsSingle();
        Container.Bind<MoveController>().FromComponentInHierarchy().AsSingle();
        
    }
}
