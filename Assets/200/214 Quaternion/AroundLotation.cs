using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundLotation : MonoBehaviour {
	public Transform target;
	public float speed = 3f;
	public float speedTurn = 180f;
	float speedTurn2;
	Vector3 dir;
	Quaternion dirQ;

	void Update () {
		speedTurn2 = 1 / speedTurn;
		dir = target.position - transform.position;
		dirQ = Quaternion.LookRotation (dir);		
		transform.rotation = Quaternion.Slerp (transform.rotation, dirQ, speedTurn2 * Time.deltaTime);
		transform.Translate (Vector3.forward * speed * Time.deltaTime);

	}
}
