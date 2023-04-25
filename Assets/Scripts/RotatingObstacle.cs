using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    [SerializeField]
    private float _maxAngleZ;
    
    private Vector3 _rotation;

    private void Awake()
    {
        var zAngle = Random.Range(0, _maxAngleZ);
        _rotation = new Vector3(0, 0, zAngle);
    }

    private void Update()
    {
        transform.Rotate(_rotation);
    }
}