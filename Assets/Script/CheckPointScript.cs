using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointScript : MonoBehaviour {

    public GameObject Checkpoint;
    public float spawnerX;
    public float spawnerY;

    public bool last;       // designate last checkpoint in level with checkmark
    public string whichLevel;
    public LevelManager Level;

    // Use this for instantiation
    void Start() {
        Level = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        Checkpoint = GameObject.Find("PlayerSpawner");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (last)
            {
                Level.GoToLevel(whichLevel);
            }
            spawnerX = this.transform.position.x;
            spawnerY = this.transform.position.y;

            Checkpoint.transform.position = new Vector3(spawnerX, spawnerY);
        }
    }
}
