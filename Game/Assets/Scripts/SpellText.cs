using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellText : MonoBehaviour
{
    Text textObj;
	[SerializeField] GameObject obj;
	
	void Start()
	{
		textObj = GetComponent<Text>();
	}
	
    void Update()
    {
        textObj.text = "Spell: " + obj.GetComponent<CastSpell>().projectile.name;
    }
}
