using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HomeTextScript : MonoBehaviour {

	public Text selvl, x2B, shieldB, MixB, L5, L10, LFull, LUn;

	void Start () {
		int lan = PlayerPrefs.GetInt ("lan", 0);

		switch (lan) {
		case 0:
			selvl.text = "Selecciona nivell";
			x2B.text = "3 Doble Puntuació";
			shieldB.text = "3 Escut";
			MixB.text = "5 de Cada";
			L5.text = "5 Vides";
			L10.text = "10 Vides";
			LFull.text = "Vides Completes";
			LUn.text = "Vides Il·limitades";
			break;
		case 1: 
			selvl.text = "Selecciona nivel";
			x2B.text = "3 Doble Puntuación";
			shieldB.text = "3 Escudo";
			MixB.text = "5 de Cada";
			L5.text = "5 Vidas";
			L10.text = "10 Vidas";
			LFull.text = "Vidas Completas";
			LUn.text = "Vidas Ilimitadas";
			break;
		case 2: 
			selvl.text = "Select Level";
			x2B.text = "3 Double Score";
			shieldB.text = "3 Shield";
			MixB.text = "5 of Each";
			L5.text = "5 Lifes";
			L10.text = "10 Lifes";
			LFull.text = "Full Lifes";
			LUn.text = "Unlimited Lifes";
			break;
		}
	}
}
