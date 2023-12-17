using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int damage = 10; // Adjust the damage value as needed
    public float speed = 5f;

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player == null)
        {
            Debug.LogError("Player object not found.");
            Destroy(this.gameObject);
        }

        // Set the bullet's velocity towards the player
        Vector2 direction = (player.position - transform.position).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed;

        Destroy(this.gameObject, 2); // Adjust the lifetime of the bullet
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // Assuming the player has a health component
            PlayerStats playerHealth = other.GetComponent<PlayerStats>();

            if (playerHealth != null)
            {
                // Damage the player
                playerHealth.TakeDamage(damage);
            }

            // Destroy the bullet
            Destroy(this.gameObject);
        }
    }
}
