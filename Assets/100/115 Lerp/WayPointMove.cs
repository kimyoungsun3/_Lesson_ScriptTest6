using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMove : MonoBehaviour {
	int index;
	public Transform wayPointRoot;
	public List<Vector3> wayPoints = new List<Vector3>();
	public float speed = 2f;
	Vector3 nextPoint;
	Transform trans;

	// Use this for initialization
	void Start () {
		trans = transform;//GetComponet<Transform>();
		if (wayPointRoot != null) {
			wayPoints.Clear ();
			for (int i = 0, iMax = wayPointRoot.childCount; i < iMax; i++)
				wayPoints.Add (wayPointRoot.GetChild (i).position);
		}
		index = 0;
		nextPoint = wayPoints [index];
	}
	
	// Update is called once per frame
	void Update () {
		if (trans.position == nextPoint) {
			index = ++index % wayPoints.Count;
			if (index == 0) {
				wayPoints.Reverse ();
			}

			nextPoint = wayPoints [index];
		}
		trans.position = Vector3.MoveTowards (trans.position, nextPoint, speed * Time.deltaTime);
	}
}
