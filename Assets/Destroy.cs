using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {


		void OnTriggerEnter (Collider other)
		{
			if(other.tag == "monster")
			{
				Debug.Log("Collision");
				Destroy(other.gameObject);
			}
		}

}