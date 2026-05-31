using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public GameUI gameUI;

    void Start()
    {
        currentHealth = maxHealth;
        gameUI.UpdateHealth(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        gameUI.UpdateHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Debug.Log("Игрок погиб");
            Destroy(gameObject);
        }
    }
}