using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LvlControlScript : MonoBehaviour {

	string sceneName;
	public GameObject P1, P2, P3, P4, P5, P6, C1, C2, C3, C4, C5, C6, giro, L1_1, L1_2, L1_3, L1_4, L1_5, L1_6, L2_1, L2_2, L2_3, L2_4, L2_5, L2_6, L3_1, L3_2, L3_3, L3_4, L3_5, L3_6, L4_1, L4_2, L4_3, L4_4, L4_5, L4_6, L5_1, L5_2, L5_3, L5_4, L5_5, L5_6, L6_1, L6_2, L6_3, L6_4, L6_5, L6_6;
	int lvlScene;
	float time;
	int ins=1;

	void Start () {
		sceneName = SceneManager.GetActiveScene ().name;
		if (sceneName=="Lvl-1") {
			time = 1.0f;
			lvlScene = 1;
		} else if (sceneName=="Lvl-2") {
			time=1.0f;
			lvlScene = 2;
		} else if (sceneName=="Lvl-3") {
			lvlScene = 3;
		} else if (sceneName=="Lvl-4") {
			time = 5.0f;
			lvlScene = 4;
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
		case 4:
			if (time <= 0.0f && ins == 1) {
				Instantiate (L1_4, new Vector2 (0.0f, 0.0f), transform.rotation);
				ins++;
				time = 1.0f;
			} else if (time <= 0.0f && ins == 2) { 
				Instantiate (L2_1, new Vector2 (0.0f, 0.0f), transform.rotation);
				ins++;
				time = 1.0f;
			} else if (time <= 0.0f && ins == 3) { 
				Instantiate (L3_2, new Vector2 (0.0f, 0.0f), transform.rotation);
				ins++;
				time = 1.0f;
			} else if (time <= 0.0f && ins == 4) { 
				Instantiate (L4_3, new Vector2 (0.0f, 0.0f), transform.rotation);
				ins++;
				time = 1.0f;
			} else if (time <= 0.0f && ins == 5) { 
				Instantiate (L5_5, new Vector2 (0.0f, 0.0f), transform.rotation);
				ins++;
				time = 1.0f;
			} else if (time <= 0.0f && ins == 6) { 
				Instantiate (L6_6, new Vector2 (0.0f, 0.0f), transform.rotation);
				ins++;
				time = 1.0f;
			} else if (time <= 0.0f && ins == 7) { 
				SceneManager.LoadScene ("GameOver");
			}
			break;
		}
		time -= Time.deltaTime;
	}
}
