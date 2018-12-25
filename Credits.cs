using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {

    public GameObject creditsCanvas;
    public GameObject MainMenuCanvas;

    public void credits()
    {
        creditsCanvas.SetActive(true);
        MainMenuCanvas.SetActive(false);
    }

    public void BackMainMenu()
    {
        creditsCanvas.SetActive(false);
        MainMenuCanvas.SetActive(true);
    }
}
