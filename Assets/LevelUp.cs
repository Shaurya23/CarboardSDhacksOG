using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Text;

public class LevelUp : MonoBehaviour {
	String txt = "0";

	void OnEnable() {
		ActualDestroyer.levelUp += incrementLevel;
	}
	//void OnDisable() {
	//	ActualDestroyer.levelUp -= incrementLevel;
	//}

	void incrementLevel() {
		txt = GetComponent<Text>().text;
		int levelNum = int.Parse (txt);
		levelNum++;
		txt = levelNum.ToString();
		GetComponent<Text>().text = txt;
	}

}
