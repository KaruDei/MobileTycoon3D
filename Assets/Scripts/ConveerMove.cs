using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveerMove : MonoBehaviour
{
    [SerializeField] private float _conveerSpeed;

    private Vector3 _direction;

    private void Awake()
    {
        _direction = new Vector3(0, 0, _conveerSpeed * Time.deltaTime);
    }

    private void OnCollisionStay(Collision collision)
    {
        collision.transform.position = collision.transform.position + _direction;
    }
}
