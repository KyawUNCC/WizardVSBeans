using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsText : MonoBehaviour
{
    Text textObj;
	[SerializeField] GameObject obj;
	
	void Start()
	{
		textObj = GetComponent<Text>();
	}
	
    void Update()
    {
        textObj.text = "Points: " + obj.GetComponent<Score>().points;
    }
}
