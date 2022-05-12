using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpikeIndicator : MonoBehaviour
{
    Color alpha;
    //bool swap = true;
    
    void Start()
    {
        alpha = gameObject.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
