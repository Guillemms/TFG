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
	int lan, count = 0, mult = 1;
	float time, songTime = 0.0f;
	Text scoreTxt;
	AudioSource music;
	bool x2, shield;

	void Start () {
		/*int lvl = HomeInteractiveScript.lvl;
		x2 = BoostersScript.x2;
		if (x2)
			mult = 2;
		shield = BoostersScript.shield;*/
		lan = OptionsTextControl.language;
		sceneName = SceneManager.GetActiveScene ().name;
		if (sceneName=="Lvl-1") {//canviar per lvl
			time = 0.5f;
			InvokeRepeating ("lvl1", 0.0f, time/rep);
		} else if (sceneName=="Lvl-2") {
			time=1.0f;
			InvokeRepeating ("lvl2", 0.0f, time/rep);
		} else if (sceneName=="Lvl-3") {
			time=1.0f;
			InvokeRepeating ("lvl3", 0.0f, time/rep);
		} else if (sceneName=="Lvl-4") {
			time = 3.0f;
			InvokeRepeating ("lvl4", 0.0f, time/rep);
		} else if (sceneName=="Lvl-5") {
			time = 5.0f;
			InvokeRepeating ("lvl5", 0.0f, time/rep);
		}

		music = GameObject.Find ("MusicSource").GetComponent<AudioSource> ();
		points = 0;
		Score (0);
	}

	void Update(){
		if (songTime >= music.clip.length/rep) {
			songTime = 0.0f;
			if (music.pitch < 3.0f) {
				rep += 0.25f;
				music.pitch += 0.25f;
			}
		}
		songTime += Time.deltaTime;
	}

	public void Score(int s){
		points += s*mult;
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
		/*if (shield) {
			shield = false;
		} else {
			SceneManager.LoadScene ("GameOver");
		}*/
		SceneManager.LoadScene ("GameOver");
	}

	void lvl1(){
		Instantiate (P [Random.Range (0, 6)], new Vector3 (Random.Range (-1.9f, 1.9f),Random.Range (-3.7f, 3.2f), 0.0f), transform.rotation);
	}

	void lvl2(){
		int el = Random.Range (0, 3);
		if (el == 0 || el == 1) {
			Instantiate (P [Random.Range (0, 6)], new Vector3 (Random.Range (-1.9f, 1.9f), Random.Range (-3.7f, 3.2f), 0.0f), transform.rotation);
		} else {
			Instantiate (C [Random.Range (0, 6)], new Vector3 (Random.Range (-1.8f, 1.8f), Random.Range (-3.6f, 3.06f), 0.0f), transform.rotation);
		}
	}

	void lvl3(){
		count++;
		if (count == 25) {
			count = 0;
			Instantiate (giro, new Vector3(0.0f, 4.3f, 0.0f), transform.rotation);
		} else {
			int el = Random.Range (0, 2);
			if (el == 0) {
				Instantiate (P [Random.Range (0, 6)], new Vector3 (Random.Range (-1.9f, 1.9f), Random.Range (-3.7f, 1.3f), 0.0f), transform.rotation);
			} else {
				Instantiate (C [Random.Range (0, 6)], new Vector3 (Random.Range (-1.8f, 1.8f), Random.Range (-3.6f, 1.18f), 0.0f), transform.rotation);
			}
		}


	}

	void lvl4(){
		switch (count) {
		case 0: 
			Instantiate (L1 [Random.Range (0, 6)], new Vector3 (-1.08f, 2.96f, 0.0f), transform.rotation);
			break;
		case 1: 
			Instantiate (L1 [Random.Range (0, 6)], new Vector3 (-0.89f, 1.48f, 0.0f), transform.rotation);
			break;
		case 2: 
			Instantiate (L1 [Random.Range (0, 6)], new Vector3 (1.02f, 1.92f, 0.0f), transform.rotation);
			break;
		case 3: 
			Instantiate (L1 [Random.Range (0, 6)], new Vector3 (-0.78f, -1.3f, 0.0f), transform.rotation);
			break;
		case 4: 
			Instantiate (L1 [Random.Range (0, 6)], new Vector3 (1.16f, -0.99f, 0.0f), transform.rotation);
			break;
		case 5: 
			Instantiate (L1 [Random.Range (0, 6)], new Vector3 (1.08f, -2.87f, 0.0f), transform.rotation);
			break;
		case 6: 
			Instantiate (L2 [Random.Range (0, 6)], new Vector3 (1.51f, -0.06f, 0.0f), transform.rotation);
			break;
		case 7: 
			Instantiate (L2 [Random.Range (0, 6)], new Vector3 (-1.58f, -0.06f, 0.0f), Quaternion.Euler(0.0f, 0.0f, -180.0f));
			break;
		case 8: 
			Instantiate (L2 [Random.Range (0, 6)], new Vector3 (0.09f, 2.16f, 0.0f), Quaternion.Euler(0.0f, 0.0f, 90.0f));
			break;
		case 9: 
			Instantiate (L2 [Random.Range (0, 6)], new Vector3 (-0.03f, -2.68f, 0.0f), Quaternion.Euler(0.0f, 0.0f, -90.0f));
			break;
		case 10: 
			Instantiate (L3 [Random.Range (0, 6)], new Vector3 (-0.27f, 2.24f, 0.0f), Quaternion.Euler(0.0f, 0.0f, 25.98f));
			break;
		case 11: 
			Instantiate (L3 [Random.Range (0, 6)], new Vector3 (0.22f, -2.16f, 0.0f), Quaternion.Euler(0.0f, 0.0f, -69.36f));
			break;
		case 12: 
		case 15:
			Instantiate (L1 [Random.Range (0, 6)], new Vector3 (0.92f, 2.83f, 0.0f), Quaternion.Euler(0.0f, 0.0f, 90.0f));
			break;
		case 13: 
			Instantiate (L2 [Random.Range (0, 6)], new Vector3 (0.0f, 0.0f, 0.0f), Quaternion.Euler(0.0f, 0.0f, 47.56f));
			break;
		case 14: 
			Instantiate (L1 [Random.Range (0, 6)], new Vector3 (-1.05f, -2.75f, 0.0f), Quaternion.Euler(0.0f, 0.0f, 90.0f));
			break;
		case 16: 
				Instantiate (L3 [Random.Range (0, 6)], new Vector3 (0.0f, 0.0f, 0.0f), Quaternion.Euler(0.0f, 0.0f, 45.54f));
			break;
		case 17:
			Instantiate (L1 [Random.Range (0, 6)], new Vector3 (-1.05f, -2.75f, 0.0f), Quaternion.Euler (0.0f, 0.0f, 90.0f));
			count = -1;
			break;
		}
		count++;
	}

	void lvl5(){
		switch (count) {
		case 0: 
			Instantiate (L5 [Random.Range (0, 6)], new Vector3 (0.86f, 2.68f, 0.0f), Quaternion.Euler (0.0f, 0.0f, -38.15f));
			break;
		case 1: 
			Instantiate (L4 [Random.Range (0, 6)], new Vector3 (0.00f, -1.98f, 0.0f), transform.rotation);
			break;
		case 2: 
			Instantiate (L6 [Random.Range (0, 6)], new Vector3 (-0.34f, 2.03f, 0.0f), Quaternion.Euler (0.0f, 0.0f, 28.82f));
			break;
		case 3: 
			Instantiate (L6 [Random.Range (0, 6)], new Vector3 (0.12f, -2.13f, 0.0f), transform.rotation);
			break;
		case 4: 
			Instantiate (L4 [Random.Range (0, 6)], new Vector3 (0.09f, 2.56f, 0.0f), Quaternion.Euler (0.0f, 0.0f, 90.00f));
			break;
		case 5: 
			Instantiate (L4 [Random.Range (0, 6)], new Vector3 (0.0f, -1.79f, 0.0f), Quaternion.Euler (0.0f, 0.0f, 90.00f));
			break;
		case 6: 
			Instantiate (L5 [Random.Range (0, 6)], new Vector3 (-0.53f, 1.91f, 0.0f), Quaternion.Euler (0.0f, 0.0f, 15.00f));
			break;
		case 7: 
			Instantiate (L5 [Random.Range (0, 6)], new Vector3 (0.62f, -2.35f, 0.0f), Quaternion.Euler (0.0f, 0.0f, -165.00f));
			break;
		case 8: 
			Instantiate (L4 [Random.Range (0, 6)], new Vector3 (0.7f, 1.39f, 0.0f), Quaternion.Euler (0.0f, 0.0f, -38.15f));
			break;
		case 9: 
			Instantiate (L6 [Random.Range (0, 6)], new Vector3 (-0.03f, -2.07f, 0.0f), transform.rotation);
			break;
		case 10: 
			Instantiate (L6 [Random.Range (0, 6)], new Vector3 (0.04f, 1.88f, 0.0f), Quaternion.Euler (0.0f, 0.0f, 102.68f));
			break;
		case 11: 
			Instantiate (L5 [Random.Range (0, 6)], new Vector3 (-0.59f, -2.28f, 0.0f), Quaternion.Euler (0.0f, 0.0f, -219.14f));
			break;
		case 12: 
			Instantiate (L4 [Random.Range (0, 6)], new Vector3 (-1.32f, 2.52f, 0.0f), Quaternion.Euler (0.0f, 0.0f, 133.06f));
			break;
		case 13: 
			Instantiate (L5 [Random.Range (0, 6)], new Vector3 (1.01f, -0.06f, 0.0f), Quaternion.Euler (0.0f, 0.0f, -219.14f));
			break;
		case 14: 
			Instantiate (L6 [Random.Range (0, 6)], new Vector3 (-0.71f, -2.8f, 0.0f), Quaternion.Euler (0.0f, 0.0f, 22.3f));
			count = -1;
			break;
		}
		count++;
	}
}
