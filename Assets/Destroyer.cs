using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	public delegate void LevelAction();
	public static event LevelAction levelUp;

	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "monster")
		{
			Debug.Log("Collision");
			Destroy(other.gameObject);
			if (levelUp != null) {
				levelUp();
			}
		}
	}
}