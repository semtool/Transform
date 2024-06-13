using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _maxPosition = 4;
    private float _startPositoin = -4;
    private float _stepOfMoving = 1f;
    private bool isSwiched = true;
    private Vector3 _nextPosition;

    private void Update()
    {
        _nextPosition.z = _stepOfMoving;

        if (isSwiched)
        {
            transform.Translate(_nextPosition * Time.deltaTime, Space.Self);

            if (transform.localPosition.z > _maxPosition)
            {
                isSwiched = false;
            }
        }

        if (isSwiched == false)
        {
            var newPosition = transform.localPosition;
            newPosition.z = _startPositoin;
            transform.localPosition = newPosition;

            isSwiched = true;
        }
    }
}