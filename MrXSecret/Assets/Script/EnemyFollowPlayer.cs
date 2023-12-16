using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    public float speed;
    public float lineOfSight;
    public float shootingRange;
    public float nextFireTime;
    public float fireRate = 1f;
    private Transform player;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint; // Make sure to assign this in the Inspector
    public GameObject bulletParent;
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        currentHealth = maxHealth;

        // Start shooting at the player at intervals
        InvokeRepeating("ShootAtPlayer", 0f, fireRate);
    }

    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);

        if (distanceFromPlayer < lineOfSight && distanceFromPlayer > shootingRange)
        {
            // Move towards the player
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    void ShootBullet(Vector2 direction)
    {
        if (bulletPrefab != null && bulletSpawnPoint != null)
        {
            // Instantiate the bullet at the enemy's position
            GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);

            // Set the bullet's velocity based on the given direction
            newBullet.GetComponent<Rigidbody2D>().velocity = direction * speed; // Adjust bulletSpeed as needed
        }
    }

    void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Die(); // Implement what happens when the enemy dies
        }
    }

    void Die()
    {
        // Implement what happens when the enemy dies (e.g., play death animation, destroy enemy object, etc.)
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Assuming bullets have a script with a Damage property
            int damageAmount = collision.gameObject.GetComponent<BulletScript>().damage;
            TakeDamage(damageAmount);

            Destroy(collision.gameObject); // Destroy the bullet on collision
        }
    }

    void ShootAtPlayer()
    {
        if (player != null)
        {
            // Determine the direction to the player
            Vector2 directionToPlayer = (player.position - transform.position).normalized;

            // Shoot a bullet in the direction of the player
            ShootBullet(directionToPlayer);
        }
    }

    private void OnDrawGizmoSelected()
    {
        // Draw line of sight and shooting range
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSight);
        Gizmos.DrawWireSphere(transform.position, shootingRange);
    }
}
