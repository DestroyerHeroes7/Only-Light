
using UnityEngine;

public class Ground_Spawner : MonoBehaviour {

    public Transform target;
    public Transform player;
    public GameObject Block;

    public float oyunZamani;

    void Update () {

        oyunZamani = Time.time;

       


        if (player.position.x - target.position.x < 5)
        {
            Instantiate(Block, target.position, target.rotation);           
            float targetZ = Random.Range(-0.9f, 0.9f);
            target.Translate(-3, 0, targetZ);
            
            


        }
        
        
	}
}
