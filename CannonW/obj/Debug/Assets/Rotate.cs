using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public KeyCode pressUp;
    public KeyCode pressDown;
    public int count = 0;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
        if (Input.GetKeyDown(pressUp))
            count++;
        if (count > 50)
            count = 50;
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, count);
        if (Input.GetKeyDown(pressDown))
            count--;
        if (count < -35)
            count = -35;
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, count);


    }
}
