using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	int jellyCount = 0;
	public delegate void LevelAction();
	public static event LevelAction levelUp;
	public int DELAY = 10;
	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "monster")
		{
			GetComponent<MovementScript>().baseSpeed++;
			jellyCount++;
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