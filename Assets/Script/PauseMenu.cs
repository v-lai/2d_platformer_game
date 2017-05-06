using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public Transform Begin;
    public Transform End;
    private float speed;
    public ScoreUI GameEnd;
    public bool paused;

	// Use this for initialization
	void Start () {
        paused = false;
        Time.timeScale = 1;

        GameEnd = GameObject.Find("ScoreText").GetComponent<ScoreUI>();
        speed = 1000000;

        transform.position = Vector3.MoveTowards(transform.position, End.position, speed);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.P)) {
            if (paused == false) { // not paused
                paused = true;
                transform.position = Vector3.MoveTowards(transform.position, Begin.position, speed);
                Debug.Log("paused");
                Time.timeScale = 0; // 0 freezes the frame (after you move it)

            } else { 
                paused = false;
                Time.timeScale = 1; // 1 continue time like normal (before you move it)
                transform.position = Vector3.MoveTowards(transform.position, End.position, speed);
                Debug.Log("resumed");
            }    
        }

        if (GameEnd.gameOver) {
            transform.position = Vector3.MoveTowards(transform.position, Begin.position, speed);
        }
    }
}
