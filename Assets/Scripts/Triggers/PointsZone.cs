using System;
using UnityEngine;

public class PointsZone : MonoBehaviour
{
    public int pointsCount = 0;
    private GameManager _gameManager;
    
    private void Awake()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("La pelota paso por acá y le agrega: " + pointsCount.ToString());
        _gameManager.AddScore(pointsCount);
        ShowPointsFeedback(pointsCount);
        _gameManager.UpdateExperience(pointsCount);
    }

    private void ShowPointsFeedback( int damage = 1 )
    {
        GameObject damagePrefab = _gameManager.GetDamagePrefab(); 
        if (damagePrefab)
        {
            GameObject obj = Instantiate(damagePrefab, transform.position, Quaternion.identity);
            obj.GetComponent<DamageFeedback>().damage = damage;
        }
    }
}
