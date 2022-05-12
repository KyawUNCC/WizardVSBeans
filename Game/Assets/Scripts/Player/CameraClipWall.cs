using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClipWall : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Wall"))
		{
			other.GetComponent<MeshRenderer>().enabled = false;
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.CompareTag("Wall"))
		{
			other.GetComponent<MeshRenderer>().enabled = true;
		}
	}
}
