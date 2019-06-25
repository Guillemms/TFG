using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadElementScript : MonoBehaviour {

	Vector2 pos;
	public GameObject road, levelController;
	LvlControlScript sc;
	float time=5.0f, rep; 

	void Start () {
		pos = transform.position;
		sc = levelController.GetComponent<LvlControlScript> ();
		rep = LvlControlScript.rep;
		time -= rep - 1.0f;
	}

	void Update () {
		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);
			Vector2 touchPos = Camera.main.ScreenToWorldPoint (touch.position);
			switch (touch.phase) {
			case TouchPhase.Moved:
				if (GetComponent<CircleCollider2D> () == Physics2D.OverlapPoint (touchPos)) {
					transform.position = touchPos;
				}
				break;
			case TouchPhase.Ended:
				gameObject.transform.position = pos;
				break;
			}
		}

		if (time <= 0.0f) {
			sc.GameOver ();
			Destroy (road);
		}
		time -= Time.deltaTime;
	}

	public void OnTriggerEnter2D(){
		sc.Score (5);
		Destroy (road);
	}
}
