using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SelectLevelTextControl : MonoBehaviour {

	public Text score;
	GameObject[] lvl;
	public Button btn;

	void Start () {
		int lan = OptionsTextControl.language;
		lvl = GameObject.FindGameObjectsWithTag("LevelName");

		switch (lan) {
		case 0:
			score.text = "Millor Puntuació";
			btn.GetComponentInChildren<Text> ().text = "Jugar";
			for(int i = 0; i < lvl.Length; i++){
				lvl[i].GetComponent<Text> ().text = "Nivell";
			}
			break;
		case 1: 
			score.text = "Mejor Puntuación";
			btn.GetComponentInChildren<Text> ().text = "Jugar";
			for(int i = 0; i < lvl.Length; i++){
				lvl[i].GetComponent<Text> ().text = "Nivel";
			}
			break;
		case 2: 
			score.text = "Best Score";
			btn.GetComponentInChildren<Text> ().text = "Play";
			for(int i = 0; i < lvl.Length; i++){
				lvl[i].GetComponent<Text> ().text = "Level";
			}
			break;
		}
	}
}
