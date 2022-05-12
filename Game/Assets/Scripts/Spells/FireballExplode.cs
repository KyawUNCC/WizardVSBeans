using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballExplode : MonoBehaviour
{
	Rigidbody rb;
	[SerializeField] public float power;
	[SerializeField] public float radius;
	[SerializeField] float lift;
	[SerializeField] GameObject bigExp; 
	[SerializeField] GameObject smallExp;
	public bool big = false;
	
	void Start()
	{
		
	}
	
    private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag("Enemy"))
		{
			if(big)
			{
				Instantiate(bigExp, transform.position, transform.rotation);
			}
			else
			{
				Instantiate(smallExp, transform.position, transform.rotation);
			}
			
			Vector3 explosionPos = transform.position;
			Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
			foreach (Collider hit in colliders)
			{
				rb = hit.GetComponent<Rigidbody>();

				if (rb != null)
				{
					rb.AddExplosionForce(power, explosionPos, radius, lift);
					if(hit.gameObject.CompareTag("Enemy"))
					{
						if(hit.gameObject)
						{
							hit.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
							hit.gameObject.GetComponent<EnemyMovement>().enabled = false;
							hit.gameObject.GetComponent<EnemyDie>().dead = true;
							Destroy(this.gameObject);
						}
					}
				}
			}
		}
	}
}
