using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class dragger : MonoBehaviour {

    float distance = 10;
    float startPosition = 6.75f;
    float change;

    public Text shotText;

    private void Start()
    {
        Text shotText = GetComponent<Text>();
        
    }


    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);        
        objPosition.y = transform.position.y;         
        transform.position = objPosition;
        change = (startPosition - objPosition.x) * -7f;
        print(change);
        shotText.text = change.ToString("F2") + "ft";


    }


}
