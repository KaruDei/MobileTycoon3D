using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreaterOptions : MonoBehaviour
{
    [SerializeField] private int _cost;
    private TextMeshPro _text;

    private void Awake()
    {
        _text = transform.GetChild(1).GetChild(0).GetComponent<TextMeshPro>();
    }

    private void Start()
    {
        _text.text = Convert.ToString(_cost);
    }

    public int GetCost()
    {
        return _cost;
    }
}
