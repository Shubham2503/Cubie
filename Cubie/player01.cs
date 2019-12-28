using UnityEngine;

public class player : MonoBehaviour
{

    public Rigidbody rb;
    public float sideForce = 500f;
    private object collisionInfo;
    public int cs = 0;

    private float ScreenWidth;


    void Start()
    {
        ScreenWidth = Screen.width;
        rb = rb.GetComponent<Rigidbody>();

    }

    void Update()
    {
        int i = 0;

        PlayerPrefs.SetInt("TotalCoin", cs);

        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > ScreenWidth / 2)
            {
                RunChar(1.0f);
            }

            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                RunChar(-1.0f);
            }
            ++i;
        }
    }


    private void FixedUpdate()
    {

#if UNITY_EDITOR
        RunChar(Input.GetAxis("Horizontal"));
#endif


        if (rb.position.y < -1)
            {
                FindObjectOfType<GameManager>().EndGame();
            }

        
    }


    private void RunChar(float horizontalInput)
        {
            rb.AddForce(horizontalInput * sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
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
