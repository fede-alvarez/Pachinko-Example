using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public Transform ball;
    
    private Vector3 _ballStartPosition;
    
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
}
