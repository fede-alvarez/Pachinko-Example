using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ball;
    public float targetSpeed = 5.0f;
    void LateUpdate()
    {
        if (!ball) return;
        
        Vector3 targetPosition = transform.position;
        targetPosition.y = Mathf.Clamp(ball.position.y, -10.0f, 0);
        
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * targetSpeed);
    }
}
