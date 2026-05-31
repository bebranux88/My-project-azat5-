using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI scoreText;
    public Slider healthBar;
    private int score = 0;
    public void UpdateScore(int amount)
    {
        score += amount;
        scoreText.text = "Очки: " + score;

    }

    public void UpdateHealth(float value)
    {
        HealthText.text = "" + value;
        healthBar.value = value;
    }

}