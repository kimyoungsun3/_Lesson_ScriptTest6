using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test211 : MonoBehaviour {
	void Start(){
		Debug.Log ("Extension Method Test : (R)eset or (D)ouble key");
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			transform.XXXReset ();
		} else if (Input.GetKeyDown (KeyCode.D)) {
			transform.XXXDouble (2f);
		}
	}
}
