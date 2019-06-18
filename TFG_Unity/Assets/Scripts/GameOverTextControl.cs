using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOverTextControl : MonoBehaviour {

	public Text scoreTit, bsoreTit, score, bscore;

	void Start () {
		int lan = OptionsTextControl.language;
		int lvl = HomeInteractiveScript.lvl;
		int sc = LvlControlScript.points;
		int[] bs = HomeInteractiveScript.bs;

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

		if (sc > bs [lvl]) {
			bs [lvl] = sc;
		} 

		bscore.text = bs [lvl].ToString();
	}
}
