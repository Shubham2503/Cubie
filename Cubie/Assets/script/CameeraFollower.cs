using UnityEngine;

public class CameeraFollower : MonoBehaviour {

	public Transform Reference;
    public Vector3 offset;
	
	void Update ()
    {
        transform.position = Reference.position + offset;
	}
}
