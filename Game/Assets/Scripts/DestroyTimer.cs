using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    [SerializeField] float seconds;
    float counter = 0;
    void Update()
    {
        if(counter >= seconds)
        {
            Destroy(gameObject);
        }
        counter += 1 * Time.deltaTime;
    }
}
