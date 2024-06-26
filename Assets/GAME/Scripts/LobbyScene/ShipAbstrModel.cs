using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public abstract class ShipAbstrModel : MonoBehaviour
{
    //ToDo Exchange all public to private (property?);

    public string ShipName;
    public GameObject ShipPrefab;
    public Texture Texture;
    public int ShipHealth;
    public int ShipSpeed;
    public Vector3 position;
    
    public void UpdatePosition(Vector3 newPosition)
    {
       position = newPosition;
    }
}