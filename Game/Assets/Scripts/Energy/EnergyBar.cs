using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBar : MonoBehaviour
{
	[SerializeField] GameObject player;
	float energy = 100f;
	Vector3 rect;
	
    // Update is called once per frame
    void Update()
    {
		energy = player.GetComponent<CastSpell>().energy / 100f;
		rect = new Vector3(energy, 1, 1);
        transform.localScale = rect;
    }
}
