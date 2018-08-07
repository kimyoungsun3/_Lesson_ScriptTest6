using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DL : MonoBehaviour {
	Transform t;

	void Start(){
		t = transform;
	}

	void Update () {
		Debug.DrawRay (t.position, t.right * 2, Color.red);	
		Debug.DrawRay (t.position, t.up * 2, Color.green);
		Debug.DrawRay (t.position, t.forward * 2, Color.blue);
	}
}
