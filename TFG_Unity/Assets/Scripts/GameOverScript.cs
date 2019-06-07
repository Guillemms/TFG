using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

	int lvl;

	void Start(){
		lvl = HomeInteractiveScript.lvl;
	}

	void OnMouseDown () {
		if (gameObject.tag == "Back") {
			SceneManager.LoadScene ("Home");
		} else if (gameObject.tag == "Nextlvl") {
			SceneManager.LoadScene ("Lvl-"+(lvl+1));
		} else if (gameObject.tag == "Replaylvl") {
			SceneManager.LoadScene ("Lvl-"+lvl);
		}
	} 
}
