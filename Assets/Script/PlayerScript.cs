using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float speed;                     // player speed
    public float jumpHeight;                // player jump height
    public Rigidbody2D rb;
    public bool isGrounded;                // only jump when touching ground
    public bool facingRight;
    public ScoreUI addToScore;
    public PauseMenu isPaused;

	// Use this for initialization
	void Start () {
        facingRight = true;
        isGrounded = false;
        rb = GetComponent<Rigidbody2D>();
        addToScore = GameObject.Find("ScoreText").GetComponent<ScoreUI>();
        isPaused = GameObject.Find("PauseMenu").GetComponent<PauseMenu>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) // also, GetKeyDown does NOT work for platformers
        {
            transform.position += Vector3.left * speed * Time.deltaTime; // Time.deltaTime -> smooth transition
            if (facingRight) // to flip player image
            {
                SwitchScale();
            }
            // print("go left");
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            if (!facingRight) // to flip player image
            {
                SwitchScale();
            }
            // print("go right");
        }

        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && isGrounded) // must be grounded to jump
        {
            rb.AddForce(Vector3.up * jumpHeight * Time.deltaTime);
            // transform.position += Vector3.up * speed * jumpHeight * Time.deltaTime; // NO
            // print("jumping");
            isGrounded = false; // for a double jump -> create a new bool var
        }

    } // end Update

    void OnCollisionEnter2D(Collision2D col) // ground to disable jumping if not on ground
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
            // print("touching ground");
        }
    }
    void SwitchScale()
    {
        float tempX = transform.localScale.x;
        tempX *= -1;
        transform.localScale = new Vector3(tempX, transform.localScale.y);
        facingRight = !facingRight;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            print("he got me!");
            Destroy(this.gameObject);
        }
    }
}