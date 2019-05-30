using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

	void OnMouseDown () {
		if (gameObject.tag == "Back") {
			SceneManager.LoadScene ("Home");
		} else if (gameObject.tag == "Nextlvl") {

		} else if (gameObject.tag == "Replaylvl") {

		}
	} 
}
