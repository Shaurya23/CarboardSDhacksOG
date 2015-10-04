using UnityEngine;
using System.Collections;

public class deletePanel : MonoBehaviour {
	public int delay = 5;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, delay);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
