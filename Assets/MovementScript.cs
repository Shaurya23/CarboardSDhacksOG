using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	//Base speed
	public bool moving = true;
	public float baseSpeed = 0;
	private const int DELAY = 25;
	private const int DELAY2 = 30;
	// Use this for initialization
	void Start () {

	}



	// Update is called once per frame
	void Update () {	
		if (moving) {
			Vector3 temp;
			// Move in the direction of the camera.
			temp = Camera.main.transform.forward * baseSpeed * Time.deltaTime;
			temp = transform.position + temp;
			temp.y = Mathf.Max (transform.position.y, 0);
//			temp.x = Mathf.Max (transform.position.x, -325);
//			temp.x = Mathf.Min (transform.position.x, 20);
//			temp.z = Mathf.Max (transform.position.z, -255);
//			temp.z = Mathf.Min (transform.position.z, 2247);
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

}
