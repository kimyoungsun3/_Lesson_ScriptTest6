using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCenter2 : MonoBehaviour {
	public List<Transform> list = new List<Transform> ();
	Vector3 dummySpeed;
	float dummySpeedFloat;

	void Update () {
		if (list.Count > 0) {
			//1. center 
			Vector3 centerPos = Vector3.zero;
			for (int i = 0, iMax = list.Count; i < iMax; i++) {
				centerPos += list [i].position;
			}
			centerPos /= list.Count;
			centerPos.y = transform.position.y;
			//transform.position = centerPos;
			transform.position = Vector3.SmoothDamp (transform.position, centerPos, ref dummySpeed, 0.2f);

			//2. Size
			float _size = 0;// = Camera.main.orthographicSize;
			Vector3 dir;
			Vector3 centerPos2 = transform.InverseTransformPoint (centerPos);
			Vector3 targetPos;
			for (int i = 0, iMax = list.Count; i < iMax; i++) {

				targetPos = transform.InverseTransformPoint (list [i].position);
				dir = targetPos - centerPos2;
				_size = Mathf.Max (_size, Mathf.Abs( dir.y));
				_size = Mathf.Max (_size, Mathf.Abs( dir.x/Camera.main.aspect));
			}
			//Camera.main.orthographicSize = _size + 2;
			Camera.main.orthographicSize = Mathf.SmoothDamp (Camera.main.orthographicSize, _size + 2, ref dummySpeedFloat, 0.2f);

		}
		
	}
				
}