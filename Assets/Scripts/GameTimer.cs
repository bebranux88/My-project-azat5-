using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timeRemaining = 60f;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Время: " + Mathf.Ceil(timeRemaining);
        }
        else
        {
            Debug.Log("Время вышло!");
        }
    }
}