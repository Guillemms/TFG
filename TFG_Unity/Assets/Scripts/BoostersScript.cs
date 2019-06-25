using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class BoostersScript : MonoBehaviour {

	public Text playtxt;
	int bx2, bsh, x2 = 0, shield = 0, lan;
	public static bool go;
	public GameObject levelController;
	LvlControlScript sc;

	void Start () {
		go = false;
		sc = levelController.GetComponent<LvlControlScript> ();
		lan = PlayerPrefs.GetInt ("lan", 0);
		switch (lan) {
		case 0:
			playtxt.text = "Jugar sense ajudes";
			break;
		case 1: 
			playtxt.text = "Jugar sin ayudas";
			break;
		case 2: 
			playtxt.text = "Play without boosters";
			break;
		}

		bx2 = PlayerPrefs.GetInt ("Nx2", 0);
		bsh = PlayerPrefs.GetInt ("Nsheild", 0);
	}

	void OnMouseDown() {
		if (gameObject.name == "Start") {
			go = true;
		} 
	}

	public void vx2(){
		x2 = 1;
		bx2--;
		PlayerPrefs.SetInt ("Nx2", bx2);
		PlayerPrefs.SetInt ("x2", x2);
		PlayerPrefs.Save ();
		go = true;
		sc.Booster ();
	}

	public void vshield(){
		shield = 1;
		bsh--;
		PlayerPrefs.SetInt ("Nsheild", bsh);
		PlayerPrefs.SetInt ("Sheild", shield);
		PlayerPrefs.Save ();
		go = true;
		sc.Booster ();
	}
}
