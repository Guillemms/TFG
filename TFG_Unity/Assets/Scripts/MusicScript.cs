using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicScript : MonoBehaviour {

	public AudioClip lvl1, lvl2, lvl3, lvl4, lvl5, Menu;
	string scen;
	static MusicScript instance = null;
	public static MusicScript Instance{ get { return instance; } }
	int bscn=0;

	void Start () {
		if (instance != null && instance != this) {
			Destroy (this.gameObject);
			return;
		} else {
			instance = this;
		}

		AudioSource audio = GetComponent<AudioSource> ();
		DontDestroyOnLoad (this.gameObject);
		audio.clip = Menu;
		audio.Play ();
	}

	void Update () {
		int m = OptionsScript.ActM;
		if (m == 2) {
			GetComponent<AudioSource> ().mute = true;
		} else if (m == 1) {
			GetComponent<AudioSource> ().mute = false;
		}

		if (bscn!=SceneManager.GetActiveScene ().buildIndex) {
			bscn = SceneManager.GetActiveScene ().buildIndex;
			scen = SceneManager.GetActiveScene ().name;
			if (scen == "Home" || scen == "GameOver") {
				GetComponent<AudioSource> ().clip = Menu;
				GetComponent<AudioSource> ().Play ();
			} else if (scen == "Lvl-1") {
				GetComponent<AudioSource> ().clip = lvl1;
				GetComponent<AudioSource> ().Play ();
			} else if (scen == "Lvl-2") {
				GetComponent<AudioSource> ().clip = lvl2;
				GetComponent<AudioSource> ().Play ();
			} else if (scen == "Lvl-3") {
				GetComponent<AudioSource> ().clip = lvl3;
				GetComponent<AudioSource> ().Play ();
			} else if (scen == "Lvl-4") {
				GetComponent<AudioSource> ().clip = lvl4;
				GetComponent<AudioSource> ().Play ();
			} else if (scen == "Lvl-5") {
				GetComponent<AudioSource> ().clip = lvl5;
				GetComponent<AudioSource> ().Play ();
			} 
		}
	}
}