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
			Vector3 _centerPos = Vector3.zero;
			for (int i = 0, iMax = list.Count; i < iMax; i++) {
				_centerPos += list [i].position;
			}
			_centerPos /= list.Count;
			_centerPos.y = transform.position.y;
			//transform.position = centerPos;
			transform.position = Vector3.SmoothDamp (transform.position, _centerPos, ref dummySpeed, 0.2f);

			//2. Size
			float _size = 0;// = Camera.main.orthographicSize;
			Vector3 _dir2;
			Vector3 _centerPos2 = transform.InverseTransformPoint (_centerPos);
			Vector3 _targetPos2;
			float _aspect = Camera.main.aspect;
			for (int i = 0, iMax = list.Count; i < iMax; i++) {

				_targetPos2 = transform.InverseTransformPoint (list [i].position);
				_dir2 = _targetPos2 - _centerPos2;
				_size = Mathf.Max (_size, Mathf.Abs( _dir2.y));
				_size = Mathf.Max (_size, Mathf.Abs( _dir2.x/ _aspect));
			}
			//Camera.main.orthographicSize = _size + 2;
			Camera.main.orthographicSize = Mathf.SmoothDamp (Camera.main.orthographicSize, _size + 2, ref dummySpeedFloat, 0.2f);

		}
		
	}
				
}