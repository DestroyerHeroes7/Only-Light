using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour {

    public float Skor;
    long skor_long;
    int textNumber = 0;

    public Transform Player;

    public GameObject Camera;
    public GameObject Target;
    public GameObject GameObject;
    public GameObject Light;
    public GameObject FinalScoreText;
    public GameObject FinalScore;
    public GameObject HighScoreText;
    public GameObject HighScore;
    public GameObject Score;
    public GameObject RetryButton;
    public GameObject BackButton;
    public GameObject Text1, Text2, Text3;

    // Update is called once per frame

   
   



    void Update ()
    {
        
        

        if (Player.position.y > -1)
        {
            Skor = (-1) - Player.position.x;
        }
        

            if (Player.position.y < -1)
            {
            if (Skor > PlayerPrefs.GetFloat("HighScore", 0))
            {
                PlayerPrefs.SetFloat("HighScore", Skor);
                
            }

            if( textNumber == 0)
            {
                textNumber = Random.Range(1, 4);

                switch (textNumber)
                {
                    case 1:
                        Text1.SetActive(true);
                        break;
                    case 2:
                        Text2.SetActive(true);
                        break;
                    case 3:
                        Text3.SetActive(true);
                        break;
                }
            }
            
               


            GameObject.GetComponent<AdmobScript>().showInterstitialAd();



                HighScore.GetComponent<Text>().text = PlayerPrefs.GetFloat("HighScore").ToString("0");



            Camera.GetComponent<CameraFollow>().enabled = false;
            Player.GetComponent<movement>().enabled = false;
            Target.GetComponent<Ground_Spawner>().enabled = false;
            GameObject.GetComponent<Scor>().enabled = false;
            Light.GetComponent<Light>().enabled = false;
            FinalScoreText.SetActive(true);
            FinalScore.SetActive(true);
            RetryButton.SetActive(true);
            Score.SetActive(false);
            HighScore.SetActive(true);
            HighScoreText.SetActive(true);
            BackButton.SetActive(true);
            
            
            FinalScore.GetComponent<Text>().text = Skor.ToString("0");

            

        }
        
        
	}

    public void Retry()
    {
        
        SceneManager.LoadScene(1);
       
        


    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    

}
