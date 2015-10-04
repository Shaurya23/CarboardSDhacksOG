using UnityEngine;
using System.Collections;

public class ActualDestroyer : MonoBehaviour {
	
	int jellyCount = 0;
	public delegate void LevelAction();
	public static event LevelAction levelUp;
	public int DELAY = 3;
	
	private AudioSource audioSource;
	
	[SerializeField]
	public AudioClip deathSound;
	
	void Start () {
		
		audioSource = GetComponent<AudioSource> ();
		
	}
	
	void OnTriggerEnter (Collider other)
	{
		if(other != null && other.tag == "monster")
		{
			GetComponent<MovementScript>().baseSpeed++;
			jellyCount++;
			if (levelUp != null) {
				levelUp();
			}
			
			transform.LookAt (Camera.main.transform);
			audioSource.PlayOneShot(deathSound);
		}
	}
	
	void OnTriggerExit() {
	}
}
