using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Design : MonoBehaviour {

    public GameObject Player;

    

    public void SetDefault()
    {
        Player.GetComponent<Renderer>().sharedMaterial.color = Color.white;
    }

    public void SetRed()
    {
        Player.GetComponent<Renderer>().sharedMaterial.color = Color.red;
    }

    public void SetYellow()
    {
        Player.GetComponent<Renderer>().sharedMaterial.color = Color.yellow;

    }

    public void SetBlue()
    {
        Player.GetComponent<Renderer>().sharedMaterial.color = Color.blue;
    }

    public void SetGreen()
    {
        Player.GetComponent<Renderer>().sharedMaterial.color = Color.green;
    }



}
