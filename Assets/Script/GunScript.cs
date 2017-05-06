using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

    public GameObject Bullet;
    public PlayerScript Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Player = GameObject.Find("Player").GetComponent<PlayerScript>();

		if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject BulletName = null;
            BulletName = Instantiate(Bullet, transform.position, Quaternion.identity);

            if (Player.facingRight)
            {
                BulletName.name = "Right";
            }
            else if (Player.facingRight == false)
            {
                BulletName.name = "Left";
            }
        }
	}
}
