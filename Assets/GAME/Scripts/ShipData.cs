using UnityEngine;

[CreateAssetMenu(fileName = "ShipData", menuName = "ScriptableObjects/ShipData", order = 1)]
public class ShipData : ScriptableObject
{
    public string shipName;
    public GameObject shipPrefab;
    public int health;
    public int speed;
}