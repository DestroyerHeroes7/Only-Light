using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Radio : MonoBehaviour {

    public AudioClip[] Music_List;
    public GameObject MusicSource;
    public int MusicNumber;
    

     void Start ()
    {
       
        MusicNumber = Random.Range(0, 3);

        MusicSource.GetComponent<AudioSource>().clip = Music_List[MusicNumber];
        MusicSource.GetComponent<AudioSource>().Play();
    }
   
    public void Music()
    {
        MusicSource.GetComponent<AudioSource>().mute = true;
    }
    

   

    


    
}
