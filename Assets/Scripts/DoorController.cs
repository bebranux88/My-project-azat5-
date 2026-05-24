using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour
{
    public Transform door;
    public float lowerDistance = 3f;
    public float speed = 2f;
    private Vector3 originalPosition;
    private bool isOpening = false;
    void Start()
    {
        originalPosition = door.position;
    }

    IEnumerator LowerDoor()
    {
        Vector3 targetPosition = originalPosition - new Vector3(0, lowerDistance, 0);
        while (Vector3.Distance(door.position, targetPosition) > 0.01f)
        {
            door.position = Vector3.MoveTowards(door.position, targetPosition, speed *
            Time.deltaTime);
            yield return null;
        }
    }
}