using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainEnergy : MonoBehaviour
{
	[SerializeField] float rate;
	GameObject player;
	[SerializeField] public bool active;
	CastSpell cs;
	
	void Start()
	{
		player = GameObject.FindWithTag("Player");
		cs = player.GetComponent<CastSpell>();
	}

    // Update is called once per frame
    void Update()
    {
		if(active && cs.energy < 100f)
		{
			cs.energy += rate * Time.deltaTime;
		}
    }
}
