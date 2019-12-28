using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacalsScript : MonoBehaviour {


    public obstacals movement;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "player")
        {
            movement.enabled = false;
            
        }
    }


}
