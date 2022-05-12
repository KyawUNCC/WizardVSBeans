using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInRoom : MonoBehaviour
{
    [SerializeField] GameObject obj;
	[SerializeField] float rateRangeLow = 8f;
	[SerializeField] float rateRangeHigh = 30f;
	[SerializeField] float locationRangeLow = -10f;
	[SerializeField] float locationRangeHigh = 10f;
	[SerializeField] int limit = 1000;
	[SerializeField] string tagName = "Enemy";
	float cd = 0f;
	float rate = 0f;
	int count = 0;
	
	void Start()
	{
		rate = Random.Range(rateRangeLow, rateRangeHigh);
	}

    // Update is called once per frame
    void Update()
    {
		count = GameObject.FindGameObjectsWithTag(tagName).Length;
        if(count < limit && cd > rate)
		{
			spawn();
			cd = 0f;
			rate = Random.Range(rateRangeLow, rateRangeHigh);
		}	
		cd += .1f;
    }
	
	void spawn()
	{
		Instantiate(obj, new Vector3(transform.position.x + Random.Range(locationRangeLow, locationRangeHigh), transform.position.y, transform.position.z + Random.Range(locationRangeLow, locationRangeHigh)), transform.rotation);
	}
}