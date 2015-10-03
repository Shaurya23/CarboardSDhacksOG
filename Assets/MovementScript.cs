using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	//Base speed
	public float baseSpeed = .5f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {	
		// Move in the direction of the camera.
		transform.position = transform.position + Camera.main.transform.forward * baseSpeed * Time.deltaTime;
		if (Time.time > 5) {
			// Update the speed after 5 seconds
			baseSpeed = 5;
		}
	}

}
