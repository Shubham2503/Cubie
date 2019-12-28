using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacals : MonoBehaviour {

    public Rigidbody rb;
    public float forwForce = 1000f;
    public GameObject Effect;
    private object collisionInfo;

    void Start ()
    {
		
	}
	
	
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, -forwForce * Time.deltaTime);
        
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            Instantiate(Effect, transform.position, Quaternion.identity);

            FindObjectOfType<AudioManager>().Play("Hit");

            Destroy(gameObject);
        }
    }
}
