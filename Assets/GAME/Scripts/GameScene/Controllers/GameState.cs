using UnityEngine;

public static class GameState
{
    static GameState()
    {
        
    }
    public static string SelectedShipName { get; set; }
    public static GameObject SelectedShipPrefab { get; set; }
    public static int SelectedShipHealth { get; set; }
    public static int SelectedShipSpeed { get; set; }
}