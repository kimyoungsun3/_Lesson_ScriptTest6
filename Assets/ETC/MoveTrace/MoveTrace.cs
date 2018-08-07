using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrace : MonoBehaviour {
	public Transform[] links;
	public float distance = 2f;
	Vector3 prev, dir;
	Transform trans;

	// Use this for initialization
	void Start () {
		trans = transform;
	}
	
	// Update is called once per frame
	void Update () {
		prev = trans.position;
		for (int i = 0; i < links.Length; i++) {
			dir = (prev - links [i].position).normalized;
			links [i].position = prev -distance * dir;

			prev = links [i].position;
		}
	}
}
