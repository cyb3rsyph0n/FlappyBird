using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private Rigidbody2D background;

    private BoxCollider2D boxCollider2d;

    private float width;

    // Use this for initialization
	void Start ()
	{
	    background = GetComponent<Rigidbody2D>();
        boxCollider2d = GetComponent<BoxCollider2D>();

	    width = boxCollider2d.size.x;
	}
	
	// Update is called once per frame
	void Update () {
	    if (transform.position.x < -width)
	    {
            Vector2 offset = new Vector2(width * 2, 0);
	        transform.position = (Vector2)transform.position + offset;
	    }
	}
}
