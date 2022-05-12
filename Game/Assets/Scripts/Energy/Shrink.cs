using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour
{
	[SerializeField] float endAt = 3f;
	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			transform.parent.transform.localScale = new Vector3(transform.parent.transform.localScale.x - .01f, transform.parent.transform.localScale.y, transform.parent.transform.localScale.z - .01f);
		}
		if(transform.parent.transform.localScale.x <= endAt)
		{
			Destroy(transform.parent.gameObject);
		}
	}
}
