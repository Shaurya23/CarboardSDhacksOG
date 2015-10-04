﻿using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	//Base speed
	private float baseSpeed = 0;
	private const int DELAY = 10;
	private const int DELAY2 = 15;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {	
		// Move in the direction of the camera.
		transform.position = transform.position + Camera.main.transform.forward * baseSpeed * Time.deltaTime;
		if (Time.time > DELAY) {
			// Update the speed after 5 seconds
			baseSpeed = 2;
		}
		if (Time.time > DELAY2) {
			baseSpeed = 6;
		}
	}

}
