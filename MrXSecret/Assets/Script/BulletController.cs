using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //public Animator animator;
    public float speed;
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
        StartCoroutine(DestroyAfterDelay(5f)); 

    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        StartCoroutine(DestroyAfterDelay(5f));
    }
    private IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        Destroy(gameObject);
    }

    



}