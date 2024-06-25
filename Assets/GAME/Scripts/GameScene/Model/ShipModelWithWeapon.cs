using UnityEngine;

public class ShipModelWithWeapon : ShipAbstrModel, IFireable
{
    public void Fire()
    {
        Debug.Log("Fire");
    }
}