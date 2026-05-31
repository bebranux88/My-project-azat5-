using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;
    public float chaseRange = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < chaseRange)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            direction.y = 0; // Отключаем движение по вертикали
            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);

            // Поворот врага в сторону игрока
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            rb.rotation = Quaternion.Slerp(rb.rotation, lookRotation, 10f * Time.fixedDeltaTime);
        }
    }
}