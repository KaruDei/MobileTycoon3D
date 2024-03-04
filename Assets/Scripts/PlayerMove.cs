using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Joystick _joystick;

    private Vector2 _direction;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _direction = _joystick.GetDirection();

        if (_direction.magnitude > 0)
            Move();
    }

    public void Move()
    {
        //Debug.Log(_direction);
        _rigidbody.velocity = transform.TransformDirection(
            _direction.x * _speed * Time.fixedDeltaTime,
            _rigidbody.velocity.y,
            _direction.y * _speed * Time.fixedDeltaTime
        );
    }

    public void Jump()
    {
        if ( IsGround() )
        {
            _rigidbody.AddForce( new Vector3(
                _rigidbody.velocity.x,
                _rigidbody.velocity.y + _jumpForce,
                _rigidbody.velocity.z
                )
            );
        }
    }

    public bool IsGround()
    {
        return true;
    }
}
