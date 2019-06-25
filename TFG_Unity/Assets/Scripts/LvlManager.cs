using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LvlManager : MonoBehaviour {

	public Text score;
	int[] bs = new int[10];
	int lvl, i1=0;
	GameObject[] btnlvl;

	void Start(){
		for (int i = 0; i < 6; i++) {
			i1++;
			bs [i] = PlayerPrefs.GetInt ("lvl-" + i1, 0);
		}

		lvl = PlayerPrefs.GetInt ("lvl", 1);
		score.text = bs [lvl].ToString();
		btnlvl = GameObject.FindGameObjectsWithTag("BtnLvl");	
	}

	public void loadID (int i) {
		lvl = i+1;
		if (lvl > 5)
			lvl = 5;
		PlayerPrefs.SetInt ("lvl", lvl);
		PlayerPrefs.Save ();
		for(int j = 0; j < btnlvl.Length; j++)
			btnlvl [j].GetComponent<Image> ().color = j.Equals(i) ? Color.gray : Color.white;
		score.text = bs [i].ToString ();
	}

	public void loadLvl(){
		SceneManager.LoadScene ("Lvl-"+lvl);
	}
}
