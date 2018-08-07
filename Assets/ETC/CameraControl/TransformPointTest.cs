using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPointTest : MonoBehaviour {

	public Transform target;
	public Vector3 dir;

	// Update is called once per frame
	void Update () {
		target.position = transform.TransformPoint (dir);
		//target.position = transform.position + dir;
	}

	void OnDrawGizmosSelected(){
		//Debug.Log (1);
		Gizmos.color = Color.red;
		Gizmos.DrawRay (transform.position, transform.right * 2f);
		Gizmos.color = Color.green;
		Gizmos.DrawRay (transform.position, transform.up * 2f);
		Gizmos.color = Color.blue;
		Gizmos.DrawRay (transform.position, transform.forward * 2f);
	}
}
