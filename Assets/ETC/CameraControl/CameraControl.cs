using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
	public List<Transform> list = new List<Transform> ();
	public float dampTime = 0.2f;
	public float screenEdgeBuffer 	= 4f;
	public float screenEdgeMin		= 6.5f;
	public float minSize = 4f;

	Camera cam;
	float zoomSpeed;
	Vector3 moveVelocity;
	Vector3 centerPos;

	// Use this for initialization
	void Start () {
		cam = GetComponentInChildren<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		Zoom ();
	}

	void Move(){
		int _len = list.Count;
		int _count = 0;
		Vector3 _pos = Vector3.zero;
		Transform _t;

		for (int i = 0; i < _len; i++) {
			_t = list [i];
			if(_t == null || !_t.gameObject.activeSelf) {
				continue;
			}

			//거리.
			_pos += _t.position;
			_count++;
		}

		if (_count > 0) {
			centerPos = _pos / _count;
		} else {
			centerPos = Vector3.zero;
		}
		centerPos.y = transform.position.y;
		//centerPos = _pos;

		//Debug.Log (_count + ":" + _pos + ":" + centerPos);
		//transform.position = centerPos;
		transform.position = Vector3.SmoothDamp(transform.position, centerPos, ref moveVelocity, dampTime); 
	}

	void Zoom(){
		int _len = list.Count;
		int _count = 0;
		float _size = 0;
		Vector3 _dis = Vector3.zero;
		Transform _t;

		for (int i = 0; i < _len; i++) {
			_t = list [i];
			if(_t == null || !_t.gameObject.activeSelf) {
				continue;
			}

			//카메라..
			_dis = transform.InverseTransformPoint(_t.position);
			//_dis = _t.position - transform.position;
			Debug.Log (i + " > " + _dis + ":" + (_t.position - transform.position));
			_size = Mathf.Max (_size, Mathf.Abs(_dis.y));
			_size = Mathf.Max (_size, Mathf.Abs(_dis.x / cam.aspect));
		}
		Debug.Log ("step1:" + _size);
		_size += screenEdgeBuffer;
		Debug.Log ("step2:" + _size);
		_size = Mathf.Max (_size, screenEdgeMin);
		Debug.Log ("step3:" + _size);

		cam.orthographicSize = Mathf.SmoothDamp (cam.orthographicSize, _size, ref zoomSpeed, dampTime);

	}
}
