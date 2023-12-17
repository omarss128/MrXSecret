using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Detective player = FindObjectOfType<Detective>();

        if (player.transform.localScale.x < 0)
        {
            speed = -speed;
            transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        StartCoroutine(DestroyAfterDelay(3f));
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // You hit an enemy, apply damage or perform other actions
            EnemyStats enemy = other.GetComponent<EnemyStats>();

            if (enemy != null)
            {
                // Assuming the enemy has a TakeDamage method
                enemy.TakeDamage(10); // Adjust the damage value as needed

                // Destroy the bullet
                Destroy(gameObject);
            }
        }
    }

    private IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        Destroy(gameObject);
    }
}
