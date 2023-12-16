using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int damage = 10; // Adjust the damage value as needed
    GameObject target;
    public float speed;
    Rigidbody2D bulletRB;

    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        //target = GameObject.FindGameObjectWithTag("player");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
        Destroy(this.gameObject, 2);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}