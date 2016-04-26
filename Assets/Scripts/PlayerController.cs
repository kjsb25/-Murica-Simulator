using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;

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

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        if (movement[2] < 0)
            movement[2] = 0;
        rb.AddForce (movement*speed);
    }
}
