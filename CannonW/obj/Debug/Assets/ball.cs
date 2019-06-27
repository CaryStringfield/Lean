using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    public float speed;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        //speed = Random.value + 65f;
        speed = 67f;
        rb.velocity = transform.right * speed;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed = 0;
        rb.velocity = transform.right * speed;
    }


}
