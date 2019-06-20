using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOverTextControl : MonoBehaviour {

	public Text scoreTit, bsoreTit, score, bscore;

	void Start () {
		int lan = PlayerPrefs.GetInt ("lan", 0);
		int lvl = PlayerPrefs.GetInt ("lvl", 1);
		int sc = LvlControlScript.points;
		int bs = PlayerPrefs.GetInt ("lvl-" + lvl, 0);

		switch (lan) {
		case 0:
			scoreTit.text = "Puntuació";
			bsoreTit.text = "Millor Puntuació";
			break;
		case 1: 
			scoreTit.text = "Puntuación";
			bsoreTit.text = "Mejor Puntuación";
			break;
		case 2: 
			scoreTit.text = "Score";
			bsoreTit.text = "Best Score";
			break;
		}
			
		score.text = sc.ToString();

		if (sc > bs) {
			bscore.text = sc.ToString ();
			PlayerPrefs.SetInt ("lvl-" + lvl, sc);
			PlayerPrefs.Save ();
		} else {
			bscore.text = bs.ToString ();
		}
	}
}
