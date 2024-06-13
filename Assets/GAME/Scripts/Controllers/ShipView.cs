using UnityEngine;

public class ShipView : MonoBehaviour
{
    public void UpdatePosition(Vector3 position)
    {
        transform.position = position;
    }
}