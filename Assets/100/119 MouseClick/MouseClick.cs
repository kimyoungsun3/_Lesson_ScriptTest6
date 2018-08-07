using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {
	Rigidbody rb;
	public float power = 500f;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}

	//Collider -> event deal with
	void OnMouseDown(){
		rb.AddForce(transform.forward * power);
	}
}
