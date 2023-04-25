using UnityEngine;

public abstract class Obstacle : MonoBehaviour
{
    [SerializeField]
    private Vector3 _maxDelta;

    [SerializeField]
    private float _minDuration;
    [SerializeField]
    private float _maxDuration;

    private Vector3 _startState;
    private Vector3 _endState;
    
    private float _duration;
    private float _currentTime;

    private void Awake()
    {
        _startState = GetStartState(_maxDelta);
        _endState = GetEndState(_maxDelta);

        _duration = Random.Range(_minDuration, _maxDuration);
        _currentTime = Random.Range(0, _duration);
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;

        ChangeState();
    }
    
    private void ChangeState()
    {
        var progress = Mathf.PingPong(_currentTime, _duration) / _duration;
        var newState = Vector3.Lerp(_startState, _endState, progress);
        SetNewState(newState);
    }

    protected abstract void SetNewState(Vector3 newState);

    protected abstract Vector3 GetStartState(Vector3 maxDelta);

    protected abstract Vector3 GetEndState(Vector3 maxDelta);
}