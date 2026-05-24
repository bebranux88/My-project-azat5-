using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Игрок
    public Vector3 offset; // Смещение камеры
    public float smoothSpeed = 0.125f; // Плавность движения камеры
    private float currentAngle;

    void LateUpdate()
    {
        // Перемещение камеры
        Vector3 desiredPosition = target.position + target.TransformDirection(offset);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Плавное закрепление вращения камеры за персонажем
        float targetAngle = target.eulerAngles.y;
        currentAngle = Mathf.LerpAngle(currentAngle, targetAngle, smoothSpeed);
        transform.rotation = Quaternion.Euler(10f, currentAngle, 0f);
    }
}