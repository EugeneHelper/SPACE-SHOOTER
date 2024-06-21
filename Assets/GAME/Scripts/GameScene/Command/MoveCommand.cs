using UnityEngine;

public abstract class MoveCommand
{
    protected Transform transformObj;
    protected float speedObj;
    protected Vector3 directionMoveObj;

    public MoveCommand(Transform transform, Vector3 directionMove, float speed)
    {
        this.transformObj = transform;
        this.directionMoveObj = directionMove;
        this.speedObj = speed;
    }

    public abstract void Execute();
}