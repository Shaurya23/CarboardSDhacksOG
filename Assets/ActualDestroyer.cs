using UnityEngine;
using System.Collections;

public class ActualDestroyer : MonoBehaviour {

	int jellyCount = 0;
	public delegate void LevelAction();
	public static event LevelAction levelUp;
	public int DELAY = 3;
	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "monster" && other != null)
		{
			GetComponent<MovementScript>().baseSpeed++;
			jellyCount++;
			if (levelUp != null) {
				levelUp();
			}
		}
	}

}
