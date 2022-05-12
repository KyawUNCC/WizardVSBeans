using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastSpell : MonoBehaviour
{
	[SerializeField] public GameObject projectile;
	[SerializeField] GameObject arm;
	[SerializeField] float delay;
	[SerializeField] float energyRate = 2;
	GameObject proj;
	float radius;
	float count = 0f;
	Vector3 scale;
	bool big = false;
	float timer = 0f;
	bool isSet = false;
	
	[SerializeField] public float energy = 100f;
	public float cost = 0f;
	
	
    void Update()
	{
		if(Input.GetKeyDown("space"))
		{
			switch (projectile.name)
			{
				case "Fireball":
					cost = 5f;
					break;
				case "Icicle":
					cost = 15f;
					break;
				case "Ground Spike":
					if(GameObject.FindWithTag("Ground Spike"))
                    {
						GameObject.FindWithTag("Ground Spike").GetComponent<GroundExplode>().Explode();
						isSet = true;
					}
					else
                    {
						isSet = false;
                    }
					cost = 20f;
					break;
			}	
			if(energy >= cost)
			{
				if (projectile.name != "Ground Spike" || !isSet)
				{
					Spell();
				}
				count = 0f;
				radius = 1f;
				scale = new Vector3(.5f, .5f, .5f);
				big = false;
				if (projectile.name != "Ground Spike")
				{
					proj.GetComponent<Collider>().isTrigger = true;
				}
			}
			
			
		}
		if(energy >= cost)
		{
			
			if(Input.GetKey("space"))
			{
				if(count > delay)
				{ 
					if(projectile.name == "Fireball" && energy >= 30f)
					{
						Fireball();
						cost = 30f;
					}
					if(projectile.name == "Icicle" && energy >= 35f)
					{
						Icicle();
						cost = 35f;
					}

				}
				count += 1 * Time.deltaTime;
			}
			
			if(Input.GetKeyUp("space"))
			{
				if(proj)
                {
					proj.GetComponent<MoveStraight>().charge = false;
				}
				if (projectile.name == "Fireball")
				{
					proj.GetComponent<FireballExplode>().radius = radius;
					proj.GetComponent<FireballExplode>().big = big;
					proj.GetComponent<Collider>().isTrigger = false;
					energy -= cost;
					cost = 5f;
				}
				if(projectile.name == "Icicle")
				{
					proj.GetComponent<IcicleAttack>().big = big;
					energy -= cost;
					cost = 15f;
				}
				if (projectile.name == "Ground Spike")
                {
					energy -= cost;
                }
				if (proj)
				{
					proj.transform.rotation = transform.rotation;
				}
			}
		}
		
		if(energy < 100)
		{
			timer += 1 * Time.deltaTime;
			if(timer > 2)
			{
				energy += energyRate;
				timer = 0f;
			}
		}
	}
	
	void Spell()
	{
		proj = Instantiate(projectile, arm.transform.position, transform.rotation);
	}
	
	void Fireball()
	{
		radius = 5f;
		scale = new Vector3(.75f, .75f, .75f);
		proj.transform.localScale = scale;
		big = true;
	}
	void Icicle()
	{
		scale = new Vector3(.2f, .1f, 2f);
		proj.transform.localScale = scale;
		big = true;
	}
}

// Split this into each individual spell
// Have this be a hub to call all other scripts