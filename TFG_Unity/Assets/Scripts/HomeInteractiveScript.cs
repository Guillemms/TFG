using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HomeInteractiveScript : MonoBehaviour {

	public GameObject boosterPanel, lifePanel;
	float tpanel = 1.0f;
	bool panel = false;
	public static int lvl = 1;
	public static int[] bs = new int[10];

	void Start(){
		if (bs.Length > 0) 
			for (int i = 0; i < 10; i++) 
				bs [i] = i.Equals(5) ? 750 : 0;
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
			//SceneManager.LoadScene ("level"+lvl);
		} else if (gameObject.tag == "Selectlvl") {
			SceneManager.LoadScene ("SelectLevel");
		}
	}
}
