using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSpell : MonoBehaviour
{
	[SerializeField] GameObject spell1;
	[SerializeField] GameObject spell2;
	[SerializeField] GameObject spell3;
	float cost;
	
    int spellNum = 1;

    void Start()
    {
		cost = GetComponent<CastSpell>().cost;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
		{
			switch (spellNum)
			{
				case 1:
					GetComponent<CastSpell>().projectile = spell2;
					spellNum = 2;
					cost = 15f;
					break;
				case 2:
					GetComponent<CastSpell>().projectile = spell3;
					spellNum = 3;
					cost = 20f;
					break;
				case 3:
					GetComponent<CastSpell>().projectile = spell1;
					spellNum = 1;
					cost = 5f;
					break;
			}
		}
    }
}
