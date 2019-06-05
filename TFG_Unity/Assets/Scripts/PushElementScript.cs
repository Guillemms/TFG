using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushElementScript : MonoBehaviour {

	public GameObject ins;

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
			if (touch.phase == TouchPhase.Ended)
				if (GetComponent<CircleCollider2D> () == Physics2D.OverlapPoint (touchPos))
					Destroy (gameObject);
		}
	}
}
