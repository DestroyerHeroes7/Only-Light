using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float speed = -4f;
    public float Round = 10;
    public float oyunZamani;
    public float Speed;
    

	
	// Update is called once per frame
	void Update () {
       oyunZamani =Time.time ;

        if (oyunZamani > Round && speed >= -6f)
        {
            speed = speed - 0.25f;
            Round = Round + 10;
        }
       
        GetComponent<Rigidbody>().AddForce(new Vector3(speed, 0));


        Touch touch = Input.GetTouch(0);

        if (touch.position.x < 400)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -10));
        }
        else if (touch.position.x > 400)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 10));

        }




        //  if (Input.GetKey(KeyCode.A))
        //{
        //    GetComponent<Rigidbody>().AddForce(new Vector3(0,0,-10));
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    GetComponent<Rigidbody>().AddForce(new Vector3(0,0,10));
        //}



    }
}
