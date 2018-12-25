using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroyonload : MonoBehaviour {

    private GameObject[] music,Script,_object;
    public GameObject MusicSource;

    void Start()
    {
        _object = GameObject.FindGameObjectsWithTag("_object");
        Script = GameObject.FindGameObjectsWithTag("Script");
        music = GameObject.FindGameObjectsWithTag("Music");
        Destroy(music[1]);
        Destroy(Script[0]);
        Destroy(_object[0]);
        
    }

    // Update is called once per frame
    void Awake()
    {
        DontDestroyOnLoad(MusicSource);
    }
}
