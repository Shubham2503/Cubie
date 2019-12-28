using UnityEngine;

public class player : MonoBehaviour
{

    public Rigidbody rb;
    public float sideForce = 500f;
    private object collisionInfo;
    public int cs = 0;


    void Start()
    {

    }

    void FixedUpdate()
    {

        PlayerPrefs.SetInt("TotalCoin", cs);




        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "coin")
        {
            cs++;
            Debug.Log(cs);

        }
    }
}
