using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LvlManager : MonoBehaviour {

	public Text score;
	int[] bs;
	int lvl;
	GameObject[] btnlvl;

	void Start(){
		lvl = HomeInteractiveScript.lvl;
		bs = HomeInteractiveScript.bs;
		score.text = bs [lvl].ToString();
		btnlvl = GameObject.FindGameObjectsWithTag("BtnLvl");	
	}

	public void loadID (int i) {
		lvl = i+1;
		for(int j = 0; j < btnlvl.Length; j++)
			btnlvl [j].GetComponent<Image> ().color = j.Equals(i) ? Color.gray : Color.white;
		score.text = bs [i].ToString ();
	}

	public void loadLvl(){
		SceneManager.LoadScene ("Lvl-"+lvl);
		//SceneManager.LoadScene ("Prelvl");
	}
}
