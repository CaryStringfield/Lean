using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {

    public Transform firepoint;
    public GameObject ballPrefab;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        Destroy(GameObject.Find("ball(Clone)"), 0); 
        Instantiate(ballPrefab, firepoint.position, firepoint.rotation);
        

    }
}
