using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundExplode : MonoBehaviour
{
	Rigidbody rb;
	[SerializeField] public float power;
	[SerializeField] public float radius;
	[SerializeField] float lift;
	[SerializeField] GameObject Spikes;
	[SerializeField] float x = -.2f;
	[SerializeField] float y = -.9f;
	[SerializeField] float z = .2f;

	public void Explode()
	{
		GameObject spikes = Instantiate(Spikes);
		spikes.transform.position = new Vector3(transform.position.x + x, transform.position.y + y, transform.position.z + z);

		Vector3 explosionPos = transform.position;
		Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
		foreach (Collider hit in colliders)
		{
			rb = hit.GetComponent<Rigidbody>();

			if (rb != null)
			{
				rb.AddExplosionForce(power, explosionPos, radius, lift);
				if (hit.gameObject.CompareTag("Enemy"))
				{
					if (hit.gameObject)
					{
						hit.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
						hit.gameObject.GetComponent<EnemyMovement>().enabled = false;
						hit.gameObject.GetComponent<EnemyDie>().dead = true;
					}
				}
			}
		}

		Destroy(this.gameObject);
	}
}
