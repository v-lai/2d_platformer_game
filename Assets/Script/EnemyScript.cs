using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public float speed;
    public Transform Pos1; // position 1
    public Transform Pos2; // position 2
    public bool firstMark;
    public PlayerScript Player;

	// Use this for initialization
	void Start () {
        firstMark = false;
        Player = GameObject.Find("Player").GetComponent<PlayerScript>();
    }
	
	// Update is called once per frame
	void Update () {
		if (!firstMark)
        {
            transform.position = Vector3.MoveTowards(transform.position, Pos1.position, speed);
            if (this.transform.position.x == Pos1.transform.position.x)
            {
                firstMark = true;
            }
        }
        if (firstMark)
        {
            transform.position = Vector3.MoveTowards(transform.position, Pos2.position, speed);
            if (this.transform.position.x == Pos2.transform.position.x)
            {
                firstMark = false;
            }
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            print("enemy killed by bullet!");
            if (Player.addToScore.gameOver == false && Player.isPaused.paused == false)
            {
                Player.addToScore.score += 1;
            }
            if (Player.addToScore.gameOver)
            {
                Player.addToScore.score = 0;
            }
        }
        
    }
}
