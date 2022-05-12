using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rise : MonoBehaviour
{
    [SerializeField] float height;
    float counter = 0;
    bool stop = false;
    float y;

    void Start()
    {
        y = transform.position.y;
    }
    
    void Update()
    {
        if(!stop && counter >= height)
        {
            stop = true;
        }
        counter += 1 * Time.deltaTime;
        y += 1;
    }
}
