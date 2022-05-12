using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThrow : MonoBehaviour
{
	[SerializeField] public GameObject projectile;
	GameObject proj;
    float timer;

    // Update is called once per frame
    void Update()
    {
		if(timer >= 10f)
		{
			proj = Instantiate(projectile, transform.position, transform.rotation);
			timer = 0f;
		}
		timer += 1 * Time.deltaTime;
    }
}
