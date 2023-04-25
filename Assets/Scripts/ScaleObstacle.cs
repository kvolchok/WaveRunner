using UnityEngine;

public class ScaleObstacle : Obstacle
{
    protected override void SetNewState(Vector3 newState)
    {
        transform.localScale = newState;
    }

    protected override Vector3 GetStartState(Vector3 maxDelta)
    {
        return transform.localScale - maxDelta;
    }

    protected override Vector3 GetEndState(Vector3 maxDelta)
    {
        return transform.localScale + maxDelta;
    }
}