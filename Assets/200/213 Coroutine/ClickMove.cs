using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour {
	public LayerMask clickMask;
	public float interfal = 2;

	void Start(){
		Debug.Log ("Ground(Plane) click the mouse and move cube");
	}

	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			Ray _ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit _hit;

			if (Physics.Raycast (_ray, out _hit, 100f, clickMask)) {
				Vector3 _newPos = _hit.point + new Vector3 (0, transform.position.y, 0);
				StopCoroutine ("Movement");
				StartCoroutine ("Movement", _newPos);
			}
		}
	}

	IEnumerator Movement(Vector3 _newPos){
		while (Vector3.Distance (transform.position, _newPos) > .05f) {
			transform.position = Vector3.Lerp (transform.position, _newPos, interfal * Time.deltaTime);
			yield return null;
		}
	}
}
