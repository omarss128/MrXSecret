using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{

	public int health = 500;

	public GameObject deathEffect;

	public bool isInvulnerable = false;
	public AudioClip DeathSound;

	public void TakeDamage(int damage)
	{
		if (isInvulnerable)
			return;

		health -= damage;

		if (health <= 0)
		{
			Die();
			SoundManager.instance.PlaySound(DeathSound);
		}
	}

	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
		SceneManager.LoadSceneAsync(7);
	}

}
