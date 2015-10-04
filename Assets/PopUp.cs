using UnityEngine;
using System.Collections;

public class PopUp : MonoBehaviour {

	public GameObject flame;

	// Use this for initialization
	void Start () {
		flame = GameObject.Find ("/CardboardMain/Head/MainCamera/PopUpForHit");


		//		transform.LookAt(Camera.main.transform)
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
