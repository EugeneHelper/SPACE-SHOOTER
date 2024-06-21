using Zenject;

public class ShipSelectControllerUI
{
    private readonly ShipAbstrModel _model;

    [Inject]
    public ShipSelectControllerUI(ShipAbstrModel model)
    {
        _model = model;
    }

    public void SelectShip(ShipData shipData)
    {
        // _model.ShipName = shipData.shipName;
        // _model.ShipPrefab = shipData.shipPrefab;
        // _model.ShipHealth = shipData.health;
        // _model.ShipSpeed = shipData.speed;
    }
}