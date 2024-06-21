using UnityEngine;

public abstract class ShipAbstrModel : MonoBehaviour
{
    //ToDo Exchange all public to private (property?);

    public string ShipName;
    public GameObject ShipPrefab;
    public int ShipHealth;
    public int ShipSpeed;
    public Vector3 Position;
}