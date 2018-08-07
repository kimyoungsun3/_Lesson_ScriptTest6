using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl2 : MonoBehaviour {
	public List<Transform> list = new List<Transform> ();
	public float dampTime = 0.2f;
	public float screenMinSize = 6.5f;
	public float screenEdgeSize = 4f;

	Camera cam;
	float refSpeed;
	Vector3 refVector;

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
		Transform _t;
		Vector3 _sum = Vector3.zero;
		Vector3 _avg = Vector3.zero;
		int _count = 0;
		for (int i = 0; i < list.Count; i++) {
			_t = list [i];
			if (!_t.gameObject.activeSelf) {
				continue;
			}
			_sum += _t.position;
			_count++;
		}

		if (_count > 0) {
			_avg = _sum / _count;
		}
		_avg.y = transform.position.y;

		transform.position = Vector3.SmoothDamp (transform.position, _avg, ref refVector, dampTime);
		//transform.position = _avg;
	}

	void Zoom(){
		Transform _t;
		float _size = 0f;
		Vector3 _dir;
		for (int i = 0; i < list.Count; i++) {
			_t = list [i];
			if (!_t.gameObject.activeSelf) {
				continue;
			}

			_dir = transform.InverseTransformPoint (_t.position);

			_size = Mathf.Max (_size, Mathf.Abs(_dir.y));
			_size = Mathf.Max (_size, Mathf.Abs(_dir.x/cam.aspect));
			//_count++;
		}
		_size += screenEdgeSize;
		_size = Mathf.Max (_size, screenMinSize);

		cam.orthographicSize = Mathf.SmoothDamp (cam.orthographicSize, _size, ref refSpeed, dampTime);

	}
}
