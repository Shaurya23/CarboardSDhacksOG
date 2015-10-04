using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Text;

public class LevelUp : MonoBehaviour {
	String txt = "1";

	void onEnable() {

	}
	void onDisable() {

	}

	void incrementLevel() {
		txt = GameObject.GetComponent<Text>().text;
		int levelNum = int.Parse (txt);
		levelNum++;
		txt = levelNum.ToString;
		GameObject.GetComponent<Text>().text = txt;
	}

}
