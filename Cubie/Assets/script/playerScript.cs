using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {

    public player movement;
   

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obs")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

	
}
