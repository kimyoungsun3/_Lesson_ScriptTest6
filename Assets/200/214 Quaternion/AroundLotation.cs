using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundLotation : MonoBehaviour {
	public Transform target;
	public float speed = 3f;
	Vector3 dir;
	Quaternion dirQ;

	void Update () {
		dir = target.position - transform.position;
		dirQ = Quaternion.LookRotation (dir);		
		transform.rotation = Quaternion.Slerp (transform.rotation, dirQ, Time.deltaTime);
		transform.Translate (Vector3.forward * speed * Time.deltaTime);

	}
}
