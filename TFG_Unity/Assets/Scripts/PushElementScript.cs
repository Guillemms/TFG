using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushElementScript : MonoBehaviour {

	public GameObject ins, levelController;
	LvlControlScript sc;
	float time=3.0f, rep; 

	void Start () {
		sc = levelController.GetComponent<LvlControlScript> ();
		rep = LvlControlScript.rep;
		time -= rep - 1.0f;
	}

	void Update () {
		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);
			Vector2 touchPos = Camera.main.ScreenToWorldPoint (touch.position);
			if (touch.phase == TouchPhase.Began) { 
				if (GetComponent<CircleCollider2D> () == Physics2D.OverlapPoint (touchPos)) {
					var newIns = Instantiate (ins, transform.position, transform.rotation);
					newIns.transform.parent = gameObject.transform;
				}
			}
			if (touch.phase == TouchPhase.Ended){
				if (GetComponent<CircleCollider2D> () == Physics2D.OverlapPoint (touchPos)) {
					sc.Score (1);
					Destroy (gameObject);
				}
			}
		}
		if (time <= 0.0f) {
			sc.GameOver ();
			Destroy (gameObject);
		}
		time -= Time.deltaTime;
	}
}
