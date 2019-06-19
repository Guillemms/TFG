using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HomeInteractiveScript : MonoBehaviour {

	public GameObject boosterPanel, lifePanel;
	float tpanel = 1.0f;
	bool panel = false;
	public static int lvl = 1, live, bx2, bsh;
	public static int[] bs = new int[10];

	void Start(){
		if (bs.Length > 0) 
			for (int i = 0; i < 10; i++) 
				bs [i] = i.Equals(5) ? 750 : 0;
		
		live = 20;
		bx2 = 5;
		bsh = 5;
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
			Debug.Log (bx2);
		} else if (gameObject.tag == "Shield") {
			bsh += 3;
			Debug.Log (bsh);
		} else if (gameObject.tag == "Mix") {
			bx2 += 5;
			bsh += 5;
			Debug.Log (bsh);
			Debug.Log (bx2);
		} 
	}
}
