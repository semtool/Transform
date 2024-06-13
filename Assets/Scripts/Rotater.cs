using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _speedOfRotation;

    private float _minSpeedOfRotation = 0.05f;

    void Update()
    {
        transform.Rotate( Vector3.up  * GetSped(), Space.World);
    }

    private float GetSped()
    {
        return _minSpeedOfRotation + _speedOfRotation;
    }
}