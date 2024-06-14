using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speedOfMoving = 0.5f ;
    
    private void Update()
    {
        transform.Translate(Vector3.forward * _speedOfMoving * Time.deltaTime, Space.Self);
    }
}