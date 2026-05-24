using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpHeight = 2f;
    public float gravity = -9.81f;
    public int maxJumps = 2;
    

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;
    public float mouseSensitivity = 1000f;
    private float xRotation = 1f;
    private int jumpsleft;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Проверка, стоит ли персонаж на земле
        isGrounded = controller.isGrounded;
        if (isGrounded )
        {
            jumpsleft = maxJumps;
            if (velocity.y  < 0)
            {
                velocity.y = -2f;
            }           
        }

        // Получение ввода игрока
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * speed * Time.deltaTime);

        // Прыжок
        if (Input.GetButtonDown("Jump") && jumpsleft > 0)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            jumpsleft--;
        }

        // Применение гравитации
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseX;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.Rotate(Vector3.up * mouseX);

    }

}