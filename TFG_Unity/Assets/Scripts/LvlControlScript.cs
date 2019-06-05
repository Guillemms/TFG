using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LvlControlScript : MonoBehaviour {

	string sceneName;
	public GameObject P1, P2, P3, P4, P5, P6;
	int lvlScene;
	float time=1.0f;
	int ins=1;

	void Start () {
		sceneName = SceneManager.GetActiveScene ().name;
		if (sceneName=="Lvl-1") {
			lvlScene = 1;
		}
	}

	void Update () {
		switch (lvlScene) {
		case 1:
			if (time <= 0.0f && ins == 1) {
				Instantiate (P1, new Vector2 (0.0f, 0.0f), transform.rotation);
				ins++;
				time = 1.0f;
				Debug.Log (ins);
			} else if (time <= 0.0f && ins == 2) { 
				Instantiate (P4, new Vector2 (-1.83f, 3.22f), transform.rotation);
				ins++;
				time = 1.0f;
			} else if (time <= 0.0f && ins == 3) { 
				Instantiate (P2, new Vector2(0.35f,-3.0f), transform.rotation);
				ins++;
				time = 1.0f;
			} else if (time <= 0.0f && ins == 4) { 
				Instantiate (P6, new Vector2(1.5f,0.5f), transform.rotation);
				ins++;
				time = 1.0f;
			} else if (time <= 0.0f && ins == 5) { 
				SceneManager.LoadScene ("GameOver");
			}
			break;
		}
		time -= Time.deltaTime;
		Debug.Log (time);
	}
}
