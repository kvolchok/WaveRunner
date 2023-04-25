using UnityEngine;

public class MovingObstacle : Obstacle
{
    protected override void SetNewState(Vector3 newState)
    {
        transform.position = newState;
    }

    protected override Vector3 GetStartState(Vector3 maxDelta)
    {
        return transform.position - maxDelta;
    }

    protected override Vector3 GetEndState(Vector3 maxDelta)
    {
        return transform.position + maxDelta;
    }
}