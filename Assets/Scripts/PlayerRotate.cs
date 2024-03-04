using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;

    private Vector2 _direction;

    private void FixedUpdate()
    {
        _direction = _joystick.GetDirection();

        if (_direction.magnitude > 0)
            Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(transform.rotation.x, _direction.x, transform.rotation.z);
    }

    // Попытка 1

    ////private Vector2 _direction;
    //[SerializeField] private Transform _touchPoint;
    //private Touch _touch;
    //private Vector2 _clickPosition;

    //private void FixedUpdate()
    //{
    //    if (Input.touchCount > 0)
    //    {
    //        _clickPosition = Input.GetTouch(0).rawPosition;
    //        _touch = Input.GetTouch(0);
    //    }


    //    if (_touch.phase == TouchPhase.Moved)
    //        Rotate();
    //}

    ////public void OnPointerDown(PointerEventData eventData)
    ////{
    ////    Debug.Log("Rotate Tap: " + eventData);
    ////    if (Input.touchCount > 0)
    ////        _clickPosition = Input.GetTouch(0).position;
    ////    else
    ////        _clickPosition = Input.mousePosition;
    ////}

    ////public void OnDrag(PointerEventData eventData)
    ////{
    ////    //Vector2 _offset = Vector2.zero;
    ////    transform.Rotate(0, 1, 0);
    ////}

    ////public void OnPointerUp(PointerEventData eventData)
    ////{
    ////    _clickPosition = Vector2.zero;
    ////    //_direction = Vector2.zero;
    ////}

    //private void Rotate()
    //{
    //    Vector2 _offset = Vector2.zero;
    //    _offset = _touch.position - _clickPosition;
    //    _offset = _offset.normalized;
    //    //Debug.Log("Rotate");
    //    //Debug.Log("OFFSET " + _offset);
    //    Debug.Log("TOUCH " + _touch.position);
    //    Debug.Log("CLICK " + _clickPosition);


    //    //Debug.Log(_touchPoint.position);
    //    //Debug.Log(_touch.position.normalized);


    //    transform.Rotate(_offset.x, _offset.y, 0);
    ////    transform.Rotate(0, _offset.y, _offset.x);
    //}
}
