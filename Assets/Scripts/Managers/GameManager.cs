using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public Transform ball;

    public ProgressBar progressBar;
    public GameObject damagePrefab;
    
    private Vector3 _ballStartPosition;

    private int _gameScore = 0;
    
    void Start()
    {
        _ballStartPosition = ball.position;
        RespawnBall();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RespawnBall();
        }
    }
    
    public void RespawnBall()
    {
        ball.position = new Vector3(Random.Range(-4.0f,4.0f), _ballStartPosition.y);
        ball.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
    }

    #region Score

    public void AddScore(int score)
    {
        _gameScore += score;
        Debug.Log("El Score actual es: " + _gameScore.ToString());
    }

    public int GetGameScore()
    {
        return _gameScore;
    }

    public void ResetGameScore()
    {
        _gameScore = 0;
    }

    #endregion

    public void UpdateExperience(float exp)
    {
        progressBar.AddExperience(exp);
    }

    public GameObject GetDamagePrefab()
    {
        return damagePrefab;
    }
}
