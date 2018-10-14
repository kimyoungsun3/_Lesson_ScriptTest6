using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour {
	public LayerMask clickMask;
	public float interfal = 2;
	public float speed = 2f;
	public int mode = 1;

	void Start(){
		Debug.Log ("Ground(Plane) click the mouse and move cube");
	}

	void Update(){
		//Ray _ray2 = Camera.main.ScreenPointToRay (Input.mousePosition);
		//Debug.DrawRay (_ray2.origin, _ray2.direction * 2f, Color.blue);
		//RaycastHit _hit2;
		//if (Physics.Raycast (_ray2, out _hit2, 100f, clickMask)) {
		//	Vector3 _newPos = _hit2.point;// + new Vector3 (0, transform.position.y, 0);
		//	Debug.DrawLine (_ray2.origin, _newPos);
		//}


		if (Input.GetMouseButtonDown (0)) {
			Ray _ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit _hit;
			if (Physics.Raycast (_ray, out _hit, 100f, clickMask)) {
				Vector3 _newPos = _hit.point + new Vector3 (0, transform.position.y, 0);
				StopCoroutine ("MovementPoint");				
				StartCoroutine ("MovementPoint", _newPos);
			}
		}
	}

	IEnumerator Movement(Vector3 _newPos){
		Debug.Log ("start");
		while (Vector3.Distance (transform.position, _newPos) > .05f) {
			transform.position = Vector3.Lerp (transform.position, _newPos, interfal * Time.deltaTime);
			yield return null;
		}
	}

	IEnumerator MovementPoint(Vector3 _newPos){
		while (transform.position != _newPos) {
			transform.position = Vector3.MoveTowards (transform.position, _newPos, speed * Time.deltaTime);
			yield return null;
		}
		//Debug.Log ("end" + transform.position.x + ":" + _newPos.x);
	}

	void OnDisable(){
		Debug.Log ("OnDisable");
	}
}
