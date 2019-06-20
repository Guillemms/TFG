using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OptionsTextControl : MonoBehaviour {

	public Text music, sound, rate;
	public Sprite CatLan, EspLan, IngLan;
	public Image languageIMG; 
	public static int language=0;
	public Dropdown lanDropdown;

	void Start(){
		language = PlayerPrefs.GetInt ("lan", 0); 
		lanDropdown.value = language;
		switch (language) {
		case 0: 
			music.text = "Música";
			sound.text = "So";
			rate.text = "Qualifica";
			languageIMG.sprite = CatLan;
			break;
		case 1:
			music.text = "Música";
			sound.text = "Sonido";
			rate.text = "Califica";
			languageIMG.sprite = EspLan;
			break;
		case 2: 
			music.text = "Music";
			sound.text = "Sound";
			rate.text = "Rate";
			languageIMG.sprite = IngLan;
			break;
		}
	}

	public void Language(int languageIndex){
		switch (languageIndex) {
		case 0: 
			language = 0;
			PlayerPrefs.SetInt ("lan", language);
			music.text = "Música";
			sound.text = "So";
			rate.text = "Qualifica";
			languageIMG.sprite = CatLan;
			break;
		case 1:
			language = 1;
			PlayerPrefs.SetInt ("lan", language);
			music.text = "Música";
			sound.text = "Sonido";
			rate.text = "Califica";
			languageIMG.sprite = EspLan;
			break;
		case 2: 
			language = 2;
			PlayerPrefs.SetInt ("lan", language);
			music.text = "Music";
			sound.text = "Sound";
			rate.text = "Rate";
			languageIMG.sprite = IngLan;
			break;
		}
		PlayerPrefs.Save ();
	}
}
