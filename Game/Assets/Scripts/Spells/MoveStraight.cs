using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraight : MonoBehaviour
{
	[SerializeField] float speed = 5f;
	[SerializeField] int duration = 5;
	private float cd = 0f;
	public bool charge = true;
	[SerializeField] GameObject arm;
	void Start()
	{
		arm = GameObject.FindWithTag("Arm");
	}
	
	
    void Update()
    {
		if(charge)
		{
			transform.position = arm.transform.position;
		}
		else
		{
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
			if(cd == duration * 60)
			{
				if(this.gameObject)
				{
					Destroy(this.gameObject);
				}
			}
			cd += 1f;
		}
    }
}
