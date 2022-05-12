using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyPadOn : MonoBehaviour
{
	GameObject player;
	
    void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			GetComponent<GainEnergy>().active = true;
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			GetComponent<GainEnergy>().active = false;
		}
	}
}
