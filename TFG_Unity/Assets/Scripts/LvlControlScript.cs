using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LvlControlScript : MonoBehaviour {

	string sceneName;
	public GameObject P1, P2, P3, P4, P5, P6, C1, C2, C3, C4, C5, C6, giro;
	int lvlScene;
	float time=1.0f;
	int ins=1;

	void Start () {
		sceneName = SceneManager.GetActiveScene ().name;
		if (sceneName=="Lvl-1") {
			lvlScene = 1;
		} else if (sceneName=="Lvl-2") {
			lvlScene = 2;
		} else if (sceneName=="Lvl-3") {
			lvlScene = 3;
		}
	}

	void Update () {
		switch (lvlScene) {
		case 1:
			if (time <= 0.0f && ins == 1) {
				Instantiate (P1, new Vector2 (0.0f, 0.0f), transform.rotation);
				ins++;
				time = 1.0f;
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

		case 2:
			if (time <= 0.0f && ins == 1) {
				Instantiate (C6, new Vector2 (1.0f, 0.0f), transform.rotation);
				ins++;
				time = 1.0f;
			} else if (time <= 0.0f && ins == 2) { 
				Instantiate (C2, new Vector2 (-1.83f, 2.22f), transform.rotation);
				ins++;
				time = 1.0f;
			} else if (time <= 0.0f && ins == 3) { 
				Instantiate (C3, new Vector2(-0.35f,2.42f), transform.rotation);
				ins++;
				time = 1.0f;
			} else if (time <= 0.0f && ins == 4) { 
				Instantiate (C5, new Vector2(1.21f,-0.5f), transform.rotation);
				ins++;
				time = 1.0f;
			} else if (time <= 0.0f && ins == 5) { 
				SceneManager.LoadScene ("GameOver");
			}
			break;

		case 3:
			if (giro == null) {
				SceneManager.LoadScene ("GameOver");
			}
			break;
		}
		time -= Time.deltaTime;
	}
}
