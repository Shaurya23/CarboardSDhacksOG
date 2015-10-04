using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour {
	
	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "death")
		{
			Application.LoadLevel ("safeScene");
		}
	}
}
