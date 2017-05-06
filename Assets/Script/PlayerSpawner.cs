﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour {

    public GameObject Player;       // what we're trying to find in scene
    public GameObject PlayerSpawn;  // holds prefab of player

	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        Player = GameObject.FindGameObjectWithTag("Player");
		if (Player == null)
        {
            GameObject PlayerName = null;
            PlayerName = Instantiate(PlayerSpawn, transform.position, Quaternion.identity);
            PlayerName.name = "Player";
        }
	}
}
