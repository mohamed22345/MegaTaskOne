using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour {

    private float camerax;
    private float cameray;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void LateUpdate () {
        camerax = Camera.main.transform.position.x;
        cameray = Camera.main.transform.position.y;
        transform.position = new Vector3(camerax, cameray-1f, transform.position.z);
	}
}