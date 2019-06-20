using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class OptionsScript : MonoBehaviour {

	public Image musicIMG, soundIMG; 
	public Sprite MusicOff, MusicOn, SoundOn, SoundOff;
	public int ActM, ActS;

	void Awake(){
		if(!PlayerPrefs.HasKey("ActM"))
			PlayerPrefs.SetInt ("ActM", 1);
		if(!PlayerPrefs.HasKey("ActS"))
			PlayerPrefs.SetInt ("ActS", 1);
		PlayerPrefs.Save ();
	}

	void Start(){
		ActM = PlayerPrefs.GetInt ("ActM", 1);
		ActS = PlayerPrefs.GetInt ("ActS", 1);

		if (ActM == 2) {
			musicIMG.sprite = MusicOff;
		} else {
			musicIMG.sprite = MusicOn;
		}

		if (ActS == 2) {
			soundIMG.sprite = SoundOff;
		} else {
			soundIMG.sprite = SoundOn;
		}
	}

	void OnMouseDown(){
		if (gameObject.tag == "Back") {
			SceneManager.LoadScene ("Home");
		} else if (gameObject.tag == "Music") {
			Music ();
		} else if (gameObject.tag == "Sound") {
			Sound ();
		} else if (gameObject.tag == "RateApp") {
			//Go to PlayStore
		} 
	}

	void Music(){
		if (ActM == 1) {
			musicIMG.sprite = MusicOff;
			ActM = 2;
		} else if (ActM == 2) {
			musicIMG.sprite = MusicOn;
			ActM = 1;
		}
		PlayerPrefs.SetInt ("ActM", ActM);
		PlayerPrefs.Save ();
	}
		
	void Sound(){
		if (ActS == 1) {
			soundIMG.sprite = SoundOff;
			ActS = 2;
		} else if (ActS == 2) {
			soundIMG.sprite = SoundOn;
			ActS = 1;
		}
		PlayerPrefs.SetInt ("ActS", ActS);
		PlayerPrefs.Save ();
	}
}
