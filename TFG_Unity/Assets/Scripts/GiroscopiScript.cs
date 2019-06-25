using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroscopiScript : MonoBehaviour {

	Vector3 direction; 
	float speed = 10.0f, time = 3.0f, got = 7.0f, rep;
	public GameObject giroscopi, levelController, zone;
	LvlControlScript sc;

	void Start () {
		sc = levelController.GetComponent<LvlControlScript> ();
		rep = LvlControlScript.rep;
		got -= rep - 1.0f;
		zone.transform.position = new Vector3 (Random.Range (-1.55f, 1.55f), 2.909f, 0.0f);
	}

	void Update () {
		direction = Vector3.zero;
		direction.x = Input.acceleration.x;
		transform.Translate ((direction * Time.deltaTime)*speed);

		if (gameObject.transform.position.x <= -1.85f) {
			gameObject.transform.position = new Vector3 (-1.85f, 2.9f, 0.0f);
		} else if(gameObject.transform.position.x >= 1.85f){
			gameObject.transform.position = new Vector3 (1.85f, 2.9f, 0.0f);
		}

		if (time <= 0.0f) {
			sc.GameOver ();
			Destroy (giroscopi);
		}
		time -= Time.deltaTime;
	}

	public void OnTriggerStay2D(){
		time -= Time.deltaTime;
		if (time <= 0.0f) {
			sc.Score (5);
			Destroy (giroscopi);
		}
	}

	public void OnTriggerExit2D(){
		time = 3.0f;
	}
}
