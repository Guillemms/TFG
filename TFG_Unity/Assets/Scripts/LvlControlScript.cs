using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LvlControlScript : MonoBehaviour {

	string sceneName;
	public GameObject[] P, C, L1, L2, L3, L4, L5, L6;
	public GameObject giro;
	public static int points = 0;
	public static float rep = 1.0f;
	int ins=0, lan, lvlScene;
	float time;
	Text scoreTxt;
	AudioSource music;

	void Start () {
		//int lvl = HomeInteractiveScript.lvl;
		lan = OptionsTextControl.language;
		sceneName = SceneManager.GetActiveScene ().name;
		if (sceneName=="Lvl-1") {//canviar per lvl
			time = 0.5f;
			lvlScene = 1;
			InvokeRepeating ("lvl1", 0.0f, time * rep);
		} else if (sceneName=="Lvl-2") {
			time=1.0f;
			lvlScene = 2;
		} else if (sceneName=="Lvl-3") {
			lvlScene = 3;
		} else if (sceneName=="Lvl-4") {
			time = 1.0f;
			lvlScene = 4;
		}

		music = GameObject.Find ("MusicSource").GetComponent<AudioSource> ();
		//scoreTxt = GameObject.Find("Score").GetComponent<Text>();
		points = 0;
		Score (0);
	}

	public void Score(int s){
		points += s;
		scoreTxt = GameObject.Find("Score").GetComponent<Text>();
		switch (lan) {
		case 0:
			scoreTxt.text = "Puntuació: " + points.ToString();
			break;
		case 1: 
			scoreTxt.text = "Puntuación: " + points.ToString();
			break;
		case 2: 
			scoreTxt.text = "Score: " + points.ToString();
			break;
		}
	}

	public void GameOver(){
		SceneManager.LoadScene ("GameOver");
	}

	void lvl1(){
		Instantiate (P [Random.Range (0, 6)], new Vector3 (Random.Range (-1.9f, 1.9f),Random.Range (-3.7f, 3.2f), 0.0f), transform.rotation);
		ins++;
		if (ins == 80) {
			ins = 0;
			rep += 0.25f;
			if (music.pitch < 3.0f) {
				music.pitch += 0.25f;
			}
		}
	}

	void lvl2(){
		/*if (ins == 1) {
			Instantiate (C6, new Vector2 (1.0f, 0.0f), transform.rotation);
			ins++;
			time = 1.0f;
		} else if (ins == 2) { 
			Instantiate (C2, new Vector2 (-1.83f, 2.22f), transform.rotation);
			ins++;
			time = 1.0f;
		} else if (ins == 3) { 
			Instantiate (C3, new Vector2(-0.35f,2.42f), transform.rotation);
			ins++;
			time = 1.0f;
		} else if (ins == 4) { 
			Instantiate (C5, new Vector2(1.21f,-0.5f), transform.rotation);
			ins++;
			time = 1.0f;
		} else if (ins == 5) { 
			SceneManager.LoadScene ("GameOver");
		}*/
	}

	void lvl3(){
		if (giro == null) {
			SceneManager.LoadScene ("GameOver");
		}
	}

	void lvl4(){
		/*if (ins == 1) {
			Instantiate (L1_4, new Vector2 (0.0f, 0.0f), transform.rotation);
			ins++;
			time = 5.0f;
		} else if (ins == 2) { 
			Instantiate (L2_1, new Vector2 (0.0f, 0.0f), transform.rotation);
			ins++;
			time = 5.0f;
		} else if (ins == 3) { 
			Instantiate (L3_2, new Vector2 (0.0f, 0.0f), transform.rotation);
			ins++;
			time = 5.0f;
		} else if (ins == 4) { 
			Instantiate (L4_3, new Vector2 (0.0f, 0.0f), transform.rotation);
			ins++;
			time = 5.0f;
		} else if (ins == 5) { 
			Instantiate (L5_5, new Vector2 (0.0f, 0.0f), transform.rotation);
			ins++;
			time = 5.0f;
		} else if (ins == 6) { 
			Instantiate (L6_6, new Vector2 (0.0f, 0.0f), transform.rotation);
			ins++;
			time = 5.0f;
		} else if (ins == 7) { 
			SceneManager.LoadScene ("GameOver");
		}*/
	}

	void lvl5(){

	}
}
