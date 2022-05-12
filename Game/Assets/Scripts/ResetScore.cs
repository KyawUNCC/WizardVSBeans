using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    public void changeScore()
    {
        GetComponent<Score>().points = 0;
    }
}
