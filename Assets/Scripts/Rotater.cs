using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _speedOfRotation;

    private void Update()
    {
        transform.Rotate( Vector3.up  * _speedOfRotation * Time.deltaTime, Space.World);
    }
}