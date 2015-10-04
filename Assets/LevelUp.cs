using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Text;

public class LevelUp : MonoBehaviour {
	String txt = "0";

	void OnEnable() {
		Destroyer.levelUp += incrementLevel;
	}
	void OnDisable() {
		Destroyer.levelUp -= incrementLevel;
	}

	void incrementLevel() {
		txt = GetComponent<Text>().text;
		int levelNum = int.Parse (txt);
		levelNum++;
		txt = levelNum.ToString();
		GetComponent<Text>().text = txt;
	}

}
