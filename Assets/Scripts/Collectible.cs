using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameUI gameUI;
    public int scoreVaule = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Предмет собран!");
            gameUI.UpdateScore(scoreVaule);
            Destroy(gameObject); // Удаляем объект после сбора
        }
    }
}