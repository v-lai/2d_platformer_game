using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public PlayerScript Player;
    public bool cameraAttached;
    public float speed;
    public float PlayerX;
    public float CameraX;
    public float PlayerY;
    public float CameraY;
    public float lull; // for camera to not jitter
    public float jumpLull;

    // Use this for initialization
    void Start() {
        cameraAttached = false;
    }

    // Update is called once per frame
    void Update() {
        // this.transform.parent = Player.transform; // this does not work for this game
        Player = GameObject.Find("Player").GetComponent<PlayerScript>();

        PlayerX = Player.transform.position.x;
        CameraX = transform.position.x;

        PlayerY = Player.transform.position.y;
        CameraY = transform.position.y;

        speed = Player.speed;

        if (CameraX > PlayerX && (CameraX - PlayerX) > lull)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (CameraX < PlayerX && (PlayerX - CameraX) > lull) // greater value - lower number
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (CameraY > PlayerY && (CameraY - PlayerY) > jumpLull)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (CameraY < PlayerY && (PlayerY - CameraY) > jumpLull) 
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

    }
}
