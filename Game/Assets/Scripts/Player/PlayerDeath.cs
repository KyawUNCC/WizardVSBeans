using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
	public bool dead;
	[SerializeField] GameObject island;
	bool once = true;
	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag("Enemy"))
		{
			if(collision.gameObject.GetComponent<EnemyDie>().dead == false)
			{
				dead = true;
			}
			
		}
	}
	
	void Update()
	{
		if(dead && once)
			{
				once = false;
				Die();
			}
	}
	
	void Die()
	{
		transform.GetChild(4).parent = island.transform;
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
		GetComponent<PlayerMovement>().enabled = false;
		Invoke(nameof(ReloadLevel), 2f);
		
	}
	
	void ReloadLevel()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
