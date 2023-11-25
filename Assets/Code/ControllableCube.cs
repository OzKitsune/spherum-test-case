using UnityEngine;
using UnityEngine.VFX;

public class ControllableCube : MonoBehaviour
{
    [SerializeField] private VisualEffect _visualEffect;
    [SerializeField] private ControllableCube _otherCube;

    [SerializeField] private KeyCode _up;
    [SerializeField] private KeyCode _down;
    [SerializeField] private KeyCode _right;
    [SerializeField] private KeyCode _left;

    [SerializeField] private float _speed = 5.0f;

    private void Update()
    {
        _visualEffect.transform.LookAt(_otherCube.transform);

        var velocity = Vector3.zero;
        if (Input.GetKey(_up)) 
        {
            velocity.z += _speed;
        }
        if (Input.GetKey(_down))
        {
            velocity.z -= _speed;
        }
        if (Input.GetKey(_right))
        {
            velocity.x += _speed;
        }
        if (Input.GetKey(_left)) 
        {
            velocity.x -= _speed;
        }

        transform.position += velocity * Time.deltaTime;
    }
}
