using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spidermancontroll : MonoBehaviour {


    Vector2 newPos;
    public float speed = 1.0f;
	// Use this for initialization
	void Start () {
        newPos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
            GetComponent<SpriteRenderer>().flipX = true;
            //newPos.x -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(+speed, 0));
            //newPos.x += speed;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0 , +speed*5));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -speed));
        }
    }
}
