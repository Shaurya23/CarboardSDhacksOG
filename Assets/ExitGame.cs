using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {

	void OnEnable() {
		Cardboard.SDK.OnTrigger += PauseGame;
		Cardboard.SDK.OnTilt += CloseGame;
	}
	void OnDisable() {
		Cardboard.SDK.OnTrigger -= PauseGame;
		Cardboard.SDK.OnTilt -= CloseGame;
	}
	
	void CloseGame() {
		Application.LoadLevel ("safeScene");
	}

	void PauseGame() {
		GetComponent<MovementScript>().moving = !GetComponent<MovementScript>().moving;
	}
}
