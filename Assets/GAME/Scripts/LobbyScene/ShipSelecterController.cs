using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace GAME.Scripts.LobbyScene
{
    public class ShipSelecterController
    {
        private readonly Dictionary<ShipType, ShipAbstrModel> _shipModels;
        private ShipAbstrModel _selectedShip;

        [Inject]
        public ShipSelecterController(Dictionary<ShipType, ShipAbstrModel> shipModels)
        {
            _shipModels = shipModels;

            SetDefaultModel();
        }

        private void SetDefaultModel()
        {
            SelectShip(ShipType.HealthShip);
        }


        public void SelectShip(ShipType shipType)
        {
            if (_shipModels.TryGetValue(shipType, out var model))
            {
                _selectedShip = model;
                var command = new SaveSelectedShipCommand(_selectedShip);
                command.Execute();
            }
            else
            {
                Debug.LogError($"Ship type {shipType} not found in the dictionary.");
            }
        }

        public ShipAbstrModel GetSelectedShip()
        {
            return _selectedShip;
        }
    }
}