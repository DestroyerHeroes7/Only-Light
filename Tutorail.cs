using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorail : MonoBehaviour {

    public float a,b;
    public Text text;
	
	void Start () {
		
	}
	
	
	void Update () {

        
        float t = Time.time;
       text.color = new Color (1,1,1,Mathf.Lerp(a, b, t));
        
    }
}
