using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformScript : MonoBehaviour {

    public float speed;
    public Transform Pos1; // position 1
    public Transform Pos2; // position 2
    public bool firstMark;

    // Use this for initialization
    void Start () {
        firstMark = false;
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

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.parent = this.transform;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.parent = null;
        }
    }
}
