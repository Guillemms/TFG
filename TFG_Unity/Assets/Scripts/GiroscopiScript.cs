using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroscopiScript : MonoBehaviour {

	Vector3 direction; 
	float speed = 10.0f, time = 3.0f;
	public GameObject giroscopi, levelController;
	LvlControlScript sc;

	void Start () {
		sc = levelController.GetComponent<LvlControlScript> ();
	}

	void Update () {
		direction = Vector3.zero;
		direction.x = Input.acceleration.x;
		transform.Translate ((direction * Time.deltaTime)*speed);

		if (gameObject.transform.position.x <= -1.4f) {
			gameObject.transform.position = new Vector3 (-1.4f, 2.9f, 0.0f);
		} else if(gameObject.transform.position.x >= 1.4f){
			gameObject.transform.position = new Vector3 (1.4f, 2.9f, 0.0f);
		}
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
