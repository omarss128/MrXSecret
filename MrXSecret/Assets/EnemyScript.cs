using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float shootCooldown = 2f;
    public Transform shootPoint;
    public GameObject bulletPrefab;

    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if (player == null)
        {
            Debug.LogError("Player object not found.");
        }

        StartCoroutine(ShootRoutine());
    }

    void Update()
    {
        // Optionally, you can rotate the enemy towards the player here
        if (player != null)
        {
            Vector2 direction = (player.transform.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, angle); // Use Euler angles to set the rotation
        }
    }

    IEnumerator ShootRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(shootCooldown);

            // Shoot at the player
            if (player != null)
            {
                Vector2 direction = (player.transform.position - shootPoint.position).normalized;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                Quaternion rotation = Quaternion.Euler(0f, 0f, angle);
                Instantiate(bulletPrefab, shootPoint.position, rotation);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            // Assuming the bullet has a damage component
            BulletScript bullet = other.GetComponent<BulletScript>();

            if (bullet != null)
            {
                // Damage the enemy (if needed)
                // enemyStats.TakeDamage(bullet.damage);
            }

            // Destroy the bullet
            Destroy(other.gameObject);
        }
    }
}
