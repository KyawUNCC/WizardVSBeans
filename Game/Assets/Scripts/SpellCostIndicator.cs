using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCostIndicator : MonoBehaviour
{
	[SerializeField] GameObject player;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3((player.GetComponent<CastSpell>().cost * 2.682f) + 30f, 20f, 0);
    }
}
