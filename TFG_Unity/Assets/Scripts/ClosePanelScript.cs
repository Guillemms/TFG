using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanelScript : MonoBehaviour {

	public GameObject panel;

	void OnMouseDown(){
		if (gameObject.tag == "Close") {
			panel.gameObject.SetActive (false);
		} 
	}
}
