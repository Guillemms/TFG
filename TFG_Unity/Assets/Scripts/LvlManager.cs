using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LvlManager : MonoBehaviour {

	public Text score;
	int[] bs;
	int lvl;

	void Start(){
		lvl = HomeInteractiveScript.lvl;
		bs = HomeInteractiveScript.bs;
		score.text = bs [lvl].ToString();
	}

	public void loadID (int i) {
		lvl = i;
		score.text = bs [i].ToString ();
		//Application.LoadLevel (i.ToString ());
	}

	public void loadLvl(){
		Debug.Log("Jugar nivell " + lvl);
		//SceneManager.LoadScene ("level"+lvl);
	}
}
