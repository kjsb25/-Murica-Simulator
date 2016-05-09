using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    public float maxSpeed;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 movement = new Vector3(0.0f, 0.0f, 20.0f);
        rb.AddForce (movement*speed);
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        //float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3(moveHorizontal*2, 0.0f, 0.0f);
        rb.AddForce (movement*speed);

        //put a cap on speed
        if(Mathf.Abs(rb.velocity[0]) > maxSpeed)
        {
            if (rb.velocity[0] > 0)
            {
                rb.velocity = new Vector3(maxSpeed,0.0f,20.0f);
            }
            else
            {
                rb.velocity = new Vector3(-maxSpeed, 0.0f, 20.0f);
            }
        }
    }
}
