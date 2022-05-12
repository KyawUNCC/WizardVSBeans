using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
	[SerializeField] GameObject game;
	Rigidbody rb;
	public bool dead = false;
	float dt = 0f;
	
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	
    private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag("Projectile"))
		{
			Die();
		}
	}
	
	private void Die()
	{
		GetComponent<EnemyMovement>().enabled = false;
		rb.constraints = RigidbodyConstraints.None;
		dead = true;
	}
	
	void Update()
	{
		if(dead)
		{
			if(dt == 500f)
			{
				Destroy(this.gameObject);
				game.GetComponent<Score>().points++;
			}
			dt += 1f;
		}
	}
}
