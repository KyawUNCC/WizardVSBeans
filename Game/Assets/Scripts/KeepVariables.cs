using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepVariables : MonoBehaviour
{

    void Update()
    {
        DontDestroyOnLoad(this);
        
    }
}
