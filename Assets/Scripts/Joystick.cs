using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private RectTransform _joystick;
    private RectTransform _marker;
    private float _joystickRadius = 200f;
    private Vector2 _startPosition;
    private Vector2 _direction;

    private void Awake()
    {
        _joystick = GetComponent<RectTransform>();
        _marker = _joystick.GetChild(0).GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (Input.touchCount > 0)
            _startPosition = Input.GetTouch(0).position;
        else
            _startPosition = Input.mousePosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 offset = Vector2.zero;

        if (Input.touchCount > 0)
            offset = Input.GetTouch(0).position - _startPosition;
        else
            offset = new Vector2(Input.mousePosition.x, Input.mousePosition.y) - _startPosition;

        offset = Vector2.ClampMagnitude(offset, _joystickRadius);

        _marker.anchoredPosition = offset;

        _direction = offset.normalized;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _marker.anchoredPosition = Vector2.zero;
        _direction = Vector2.zero;
    }

    public Vector2 GetDirection()
    {
        return _direction;
    }
}
