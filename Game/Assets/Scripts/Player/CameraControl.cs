using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
	[SerializeField] float sensitivity = 5.0f;
	
	void Update()
	{
		if(Input.GetAxis("Mouse X")<0)
		{
			transform.Rotate(0,-sensitivity,0);
		}
		if(Input.GetAxis("Mouse X")>0)
		{
			transform.Rotate(0,sensitivity,0);
		}
	}
	
}
