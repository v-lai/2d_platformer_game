using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour {

    public float Timer;
    public Text timeText;

	// Use this for initialization
	void Start () {
        Timer = 0;
        timeText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;

        timeText.text = Timer.ToString("F2");
	}
}
