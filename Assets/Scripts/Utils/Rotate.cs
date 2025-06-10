using System;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float torqueForce = 2.0f;
    private Rigidbody2D _rb2d;

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _rb2d.AddTorque(torqueForce);
    }

    void FixedUpdate()
    {
        
    }
}
