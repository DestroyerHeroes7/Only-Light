using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievement : MonoBehaviour {

    public Button RedButton, YellowButton,BlueButton,GreenButton;
    public GameObject LockRed,LockYellow,LockBlue,LockGreen;
    public Text redYourScore, yellowYourScore, blueYourScore, greenYourScore;
    public GameObject redNeededScore, yellowNeededScore, blueNeededScore, greenNeededScore;

    private void Update()
    {

        redYourScore.text = PlayerPrefs.GetFloat("HighScore").ToString("0");
        yellowYourScore.text = PlayerPrefs.GetFloat("HighScore").ToString("0");
        blueYourScore.text = PlayerPrefs.GetFloat("HighScore").ToString("0");
        greenYourScore.text = PlayerPrefs.GetFloat("HighScore").ToString("0");


        if (PlayerPrefs.GetFloat("HighScore") >= 50)
        {
            RedButton.interactable = true;
            LockRed.SetActive(false);
            redNeededScore.SetActive(false);
            redYourScore.gameObject.SetActive(false);
        }
        if(PlayerPrefs.GetFloat("HighScore") >= 100)
        {
            YellowButton.interactable = true;
            LockYellow.SetActive(false);
            yellowNeededScore.SetActive(false);
            yellowYourScore.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("HighScore") >= 150)
        {
            GreenButton.interactable = true;
            LockGreen.SetActive(false);
            greenNeededScore.SetActive(false);
            greenYourScore.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("HighScore") >= 200)
        {
            BlueButton.interactable = true;
            LockBlue.SetActive(false);
            blueNeededScore.SetActive(false);
            blueYourScore.gameObject.SetActive(false);
        }
    }



}
