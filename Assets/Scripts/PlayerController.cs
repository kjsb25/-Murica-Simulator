using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    public float maxSpeed;
    private int score;
    public Text countText;
    public Text winText;
    public Text loseText;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 movement = new Vector3(0.0f, 0.0f, 20.0f);
        rb.AddForce (movement*speed);
        score = 0;
        countText.text = "Score: " + score.ToString();
        winText.text = "";
        loseText.text = "";
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
    
    void OnTriggerEnter(Collider other)
    {
        //gather eggs
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score++;
            countText.text = "Score: " + score.ToString();
        }
        else if(other.gameObject.CompareTag("Winning"))
        {
            winText.text = "You Win!\n You're final score was: " + score.ToString();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        loseText.text = "You lose!\nBetter luck next time.";
    }
}
