using UnityEngine;
using System.Collections;

public class destroyonCollision : MonoBehaviour
{
	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "monster")
		{
			Debug.Log("Collision");
			Destroy(other.gameObject);
		}
	}
}