using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

	int lvl;

	void Start(){
		lvl = PlayerPrefs.GetInt ("lvl", 1);
	}

	void OnMouseDown () {
		if (gameObject.tag == "Back") {
			SceneManager.LoadScene ("Home");
		} else if (gameObject.tag == "Nextlvl") {
			lvl++;
			if (lvl > 5)
				lvl = 5;
			PlayerPrefs.SetInt ("lvl", lvl);
			PlayerPrefs.Save ();
			SceneManager.LoadScene ("Lvl-"+lvl);
		} else if (gameObject.tag == "Replaylvl") {
			SceneManager.LoadScene ("Lvl-"+lvl);
		}
	} 
}
