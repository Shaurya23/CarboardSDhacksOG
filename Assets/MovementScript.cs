﻿using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	//Base speed
	public float baseSpeed = 0;
	private const int DELAY = 10;
	private const int DELAY2 = 13;
	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {	
	    Vector3 temp;
		// Move in the direction of the camera.
		temp = Camera.main.transform.forward * baseSpeed * Time.deltaTime;
		temp.y =  temp.y * baseSpeed * Time.deltaTime / 2;
		temp = transform.position + temp;
		temp.y = Mathf.Max (transform.position.y, 40.1f);
		transform.position = temp;

		if (Time.time > DELAY) {
			// Update the speed after 5 seconds
			baseSpeed = 2;
		}
		if (Time.time > DELAY2) {
			baseSpeed = 6;
		}
	}

}
