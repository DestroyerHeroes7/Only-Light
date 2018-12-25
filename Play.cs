using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

    
    public GameObject Script;
    
    


    private void Start()
    {
        Script.GetComponent<AdmobScript>().showInterstitialAd();
        


    }

    public void PlayButton()
    {
        
        SceneManager.LoadScene(1);
    }

    
    
}
