using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {

    public int score = 0;
    public Text myText;
    public bool gameOver;
   
	// Use this for initialization
	void Start () {
        gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
        myText.text = score.ToString();
      
        if (gameOver) {
            Time.timeScale = 0; // freezes the game
            score = 0;
        }
	}
}
