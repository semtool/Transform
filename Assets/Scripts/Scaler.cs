using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speedOfChangeScale;

    private float _stepOfChangeScale = 0.0005f;
    private float _scale = 1;
    private float _minScale = 1;
    private float _reductor = 1000;

    void Update()
    {
        transform.localScale = new Vector3(GetScale(), GetScale(), GetScale());
    }

    private float GetScale()
    {
        _scale += _stepOfChangeScale + _speedOfChangeScale / _reductor;

        if (_scale < _minScale)
        {
            _scale = _minScale;
        }

        return _scale;
    }
}