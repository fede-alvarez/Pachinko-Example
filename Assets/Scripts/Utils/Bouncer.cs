using System;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _animator.SetTrigger("Bounce");
    }
}
