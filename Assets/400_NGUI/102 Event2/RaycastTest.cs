using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	void Update () {

		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) {
			Debug.Log ("camera:" + hit.collider.name);
		}
	}
}
