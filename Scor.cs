using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scor : MonoBehaviour {

    public float Skor;
    public Transform Player;
    public Text Scorer;
    public Text FinalScore;

	
	
	// Update is called once per frame
	void Update () {

        Skor = ((-1) - (Player.position.x));
        Scorer.text = Skor.ToString("0");

       

    }
}
