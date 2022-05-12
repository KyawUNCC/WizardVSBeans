using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	[SerializeField] float speed = 5f;
	GameObject player;
	
	
	
	void Update()
	{
		player = GameObject.FindWithTag("Player");
		transform.LookAt(player.transform);
		
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
	
	
}
