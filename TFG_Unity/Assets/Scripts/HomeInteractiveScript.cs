using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HomeInteractiveScript : MonoBehaviour {

	public GameObject boosterPanel, lifePanel;
	float tpanel = 1.0f;
	bool panel = false;
	public int lvl, live, bx2, bsh;

	void Start(){
		if (PlayerPrefs.HasKey ("lvl")) {
			lvl = PlayerPrefs.GetInt ("lvl", 1);
		} else {
			PlayerPrefs.SetInt ("lvl", 1);
		}
		if(PlayerPrefs.HasKey("lives")) {
			live = PlayerPrefs.GetInt ("lives", 0);
		} else {
			PlayerPrefs.SetInt ("lives", 20);
		}
		if(PlayerPrefs.HasKey("Nx2")) {
			bx2 = PlayerPrefs.GetInt ("Nx2", 0);
		} else {
			PlayerPrefs.SetInt ("Nx2", 5);
		}
		if(PlayerPrefs.HasKey("Nsheild")) {
			bsh = PlayerPrefs.GetInt ("Nsheild", 0);
		} else {
			PlayerPrefs.SetInt ("Nsheild", 5);
		}
	}

	void Update () {
		if (tpanel > 0) {
			tpanel -= Time.fixedDeltaTime;
		} else {
			panel = true;
		}
	}

	void OnMouseDown(){
		if (gameObject.tag == "Shop" && panel == true) {
			boosterPanel.gameObject.SetActive (true);
		} else if (gameObject.tag == "Life") {
			lifePanel.gameObject.SetActive (true);
		} else if (gameObject.tag == "Options") {
			SceneManager.LoadScene ("Options");
		} else if (gameObject.tag == "Play") {
			SceneManager.LoadScene ("Lvl-"+lvl);
		} else if (gameObject.tag == "Selectlvl") {
			SceneManager.LoadScene ("SelectLevel");
		} else if (gameObject.tag == "x2") {
			bx2 += 3;
			PlayerPrefs.SetInt ("Nx2", bx2);
			PlayerPrefs.Save ();
		} else if (gameObject.tag == "Shield") {
			bsh += 3;
			PlayerPrefs.SetInt ("Nsheild", bsh);
			PlayerPrefs.Save ();
		} else if (gameObject.tag == "Mix") {
			bx2 += 5;
			bsh += 5;
			PlayerPrefs.SetInt ("Nx2", bx2);
			PlayerPrefs.SetInt ("Nsheild", bsh);
			PlayerPrefs.Save ();
		} 
	}
}
