using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour {
	
	
	private AudioSource audioSource;
	
	[SerializeField]
	public AudioClip deathSound;
	
	void Start () {
		
		audioSource = GetComponent<AudioSource> ();
		
	}
	
	void OnTriggerEnter (Collider other)
	{
		
		if(other.tag == "death")
		{
			audioSource.PlayOneShot(deathSound);
			Application.LoadLevel ("safeScene");
		}
	}
	
	
}