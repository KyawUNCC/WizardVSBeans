using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArm : MonoBehaviour
{
    [SerializeField] float speed = 5f;
	private float cd = 0f;
	GameObject player;
	bool did_it = false;
	
	void Start()
	{
		player = GameObject.FindWithTag("Player");
	}
	
    // Update is called once per frame
    void Update()
    {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
		if(cd == 5 * 60)
		{
			Destroy(this.gameObject);
		}
		cd += 1f;
    }
	
	void OnTriggerEnter(Collider other)
	{

		if(other.gameObject.CompareTag("Player") && !did_it)
		{
			other.GetComponent<PlayerDeath>().dead = true;
			did_it = true;
			Destroy(this.gameObject);
		}
	}
}
