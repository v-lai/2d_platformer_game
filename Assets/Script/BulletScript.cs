using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.name == "Left")
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (this.name == "Right")
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

    }
}
