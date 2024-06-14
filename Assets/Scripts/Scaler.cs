using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speedOfChangeScale;

    private float _stepOfChangeScale = 0.0005f;
    private float _scale = 1;
    private float _reductor = 1000;

    private void Update()
    {
        transform.localScale = Vector3.one * GetScale();
    }

    private float GetScale()
    {
        if (_speedOfChangeScale >= 0)
        {
            _scale += _stepOfChangeScale + _speedOfChangeScale / _reductor;
        }
        else 
        {
            _scale += _stepOfChangeScale;
        }

        return _scale;
    }
}