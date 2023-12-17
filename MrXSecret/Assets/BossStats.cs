using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossStats : MonoBehaviour
{
    public int maxHealth = 100; // Adjust the max health value as needed
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // Check if the enemy is defeated
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Add any death behavior here (e.g., play death animation, spawn particles, etc.)
        Destroy(gameObject);
        SceneManager.LoadSceneAsync(7);
    }
}
