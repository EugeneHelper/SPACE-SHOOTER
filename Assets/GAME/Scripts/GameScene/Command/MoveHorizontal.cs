using UnityEngine;

public class MoveHorizontal : MoveCommand
{
    public MoveHorizontal(Transform transform, Vector3 directionMove, float speed): base(transform, directionMove, speed)
    {

    }
    public override void Execute()
    {
        Debug.Log("ExecuteMove");
        transformObj.position += directionMoveObj * (speedObj * Time.deltaTime);
    }
}