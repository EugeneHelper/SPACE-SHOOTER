using Zenject;

public class ShipSelectControllerUI
{
    private readonly IShipModel _model;

    [Inject]
    public ShipSelectControllerUI(IShipModel model)
    {
        _model = model;
    }

    public void SelectShip(ShipData shipData)
    {
        _model.ShipName = shipData.shipName;
        _model.ShipPrefab = shipData.shipPrefab;
        _model.ShipHealth = shipData.health;
        _model.ShipSpeed = shipData.speed;
    }
}