using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadElementScript : MonoBehaviour {

	//Rigidbody2D rb;
	Vector2 pos;
	public GameObject road, levelController;
	LvlControlScript sc;

	void Start () {
		//rb = GetComponent<Rigidbody2D> ();
		pos = transform.position;
		sc = levelController.GetComponent<LvlControlScript> ();
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
	}

	public void OnTriggerEnter2D(){
		sc.Score (5);
		Destroy (road);
	}
}
