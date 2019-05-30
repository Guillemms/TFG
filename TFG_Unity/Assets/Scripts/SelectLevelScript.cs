using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class SelectLevelScript : MonoBehaviour {

	void OnMouseDown () {
		if (gameObject.tag == "Back") {
			SceneManager.LoadScene ("Home");
		} 
	} 
}
