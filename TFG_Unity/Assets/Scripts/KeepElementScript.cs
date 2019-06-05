using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepElementScript : MonoBehaviour {

	public GameObject ins;
	float sclX;

	void Update () {
		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);
			Vector2 touchPos = Camera.main.ScreenToWorldPoint (touch.position);
			if (touch.phase == TouchPhase.Stationary) {
				if (GetComponent<CircleCollider2D> () == Physics2D.OverlapPoint (touchPos)) {
					ins.transform.localScale += Vector3.one * .1f;
					sclX = ins.transform.localScale.x;
					if (sclX >= 3.53f)
						Destroy (gameObject);
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
	}
}
