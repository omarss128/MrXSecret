using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //public Animator animator;
    public float speed;
    private int hitCount = 0;

    void Start()
    {
      //  animator = GetComponent<Animator>();

        Detective player;

        player = FindObjectOfType<Detective>();

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
        StartCoroutine(DestroyAfterDelay(3f));
    }
    private IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        Destroy(gameObject);
    }
  
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
         if (other.tag == "FinalBoss")
        {
            hitCount++;

            if (hitCount >= 10)
            {
                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
        }
    }



}