using System;
using UnityEngine;

public class PointsZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("La pelota paso por acá");
    }
}
