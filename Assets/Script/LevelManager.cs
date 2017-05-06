﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void GoToLevel(string name) {
        SceneManager.LoadScene(name);
    }

    public void Quit() {
        Application.Quit();
        Debug.Log("game quit");
    }
}
