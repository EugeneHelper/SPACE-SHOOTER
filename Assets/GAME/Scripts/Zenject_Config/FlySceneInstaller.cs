using GAME.Scripts.Signals;
using GAME.Scripts.Zenject_Config;
using Unity.VisualScripting;
using Zenject;

public class FlySceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
       // Container.Bind<InputForMoveSignal>().AsSingle();

        // Регистрируем компоненты
        Container.Bind<ShipController>().FromComponentInHierarchy().AsSingle();
        Container.Bind<ShipAbstrModel>().FromInstance(GameState.SelectedShipPrefab.GetComponent<ShipAbstrModel>()).AsSingle().NonLazy();
    }
}
