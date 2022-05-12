using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcicleAttack : MonoBehaviour
{
	[SerializeField] Material material;
	int count = 0;
	public bool big = false;
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Enemy"))
		{
			if(other.gameObject)
			{
				other.gameObject.GetComponent<EnemyDie>().dead = true;
				other.gameObject.GetComponent<EnemyMovement>().enabled = false;
				other.gameObject.GetComponent<MeshRenderer>().material = material;
			}
			if(!big)
            {
				count++;
            }
		}
		if(count > 4)
		{
			Destroy(this.gameObject);
		}
	}
}
