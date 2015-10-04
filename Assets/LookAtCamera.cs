using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour {
	public GameObject flame;

	// Use this for initialization
	void Start () {
		flame = GameObject.Find ("PopUpForHit");
		transform.LookAt (Camera.main.transform);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
