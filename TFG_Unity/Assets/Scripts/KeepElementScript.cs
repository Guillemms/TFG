using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepElementScript : MonoBehaviour {

	public GameObject ins, levelController;
	LvlControlScript sc;
	float sclX, time=3.0f, rep;

	void Start () {
		sc = levelController.GetComponent<LvlControlScript> ();
		rep = LvlControlScript.rep;
		time -= rep - 1.0f;
	}

	void Update () {
		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);
			Vector2 touchPos = Camera.main.ScreenToWorldPoint (touch.position);
			if (touch.phase == TouchPhase.Stationary) {
				if (GetComponent<CircleCollider2D> () == Physics2D.OverlapPoint (touchPos)) {
					ins.transform.localScale += Vector3.one * .1f;
					sclX = ins.transform.localScale.x;
					if (sclX >= 3.53f) {
						sc.Score (3);
						Destroy (gameObject);
					}
				} else if (GetComponent<CircleCollider2D> () != Physics2D.OverlapPoint (touchPos)) {
					ins.transform.localScale -= Vector3.one * .05f;
					sclX = ins.transform.localScale.x;
					if (sclX <= 1.59f)
						ins.transform.localScale = Vector3.one * 1.59f;
				}
			} 
		} else {
			ins.transform.localScale -= Vector3.one * .05f;
			sclX = ins.transform.localScale.x;
			if (sclX <= 1.59f)
				ins.transform.localScale = Vector3.one * 1.59f;
		}

		if (time <= 0.0f) {
			sc.GameOver ();
		}
		time -= Time.deltaTime;
	}
}
