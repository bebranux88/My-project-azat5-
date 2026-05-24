using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject platform;
    public float Ymeters = 3.16f;
    private bool isActivated = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isActivated = !isActivated;
            if (isActivated)
            {
                platform.transform.position = new Vector3(platform.transform.position.x,
                platform.transform.position.y + Ymeters, platform.transform.position.z);
            }
            else
            {
                platform.transform.position = new Vector3(platform.transform.position.x,
                platform.transform.position.y - Ymeters, platform.transform.position.z);
            }
                platform.SetActive(isActivated);
            transform.Rotate(0, 0, isActivated ? 45f : -45f); // Поворачиваем рычаг
            Debug.Log("Рычаг переключен!");
        }
    }
}