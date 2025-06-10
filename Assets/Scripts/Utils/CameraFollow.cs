using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ball;
    
    void LateUpdate()
    {
        Vector3 targetPosition = transform.position;
        targetPosition.y = ball.position.y;
        //targetPosition.y = Mathf.Clamp(ball.position.y, -10.0f, 0);
        
        transform.position = targetPosition;
    }
}
