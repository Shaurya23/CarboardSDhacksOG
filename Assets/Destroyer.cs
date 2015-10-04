using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	public delegate void LevelAction();
	public static event LevelAction levelUp;
	public int DELAY = 10;
	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "monster")
		{
			Debug.Log("Collision");
			if (levelUp != null) {
				levelUp();
			}
			if (Time.time < DELAY) {
				return;
			}
			else
			Destroy(other.gameObject);

		}
	}
}