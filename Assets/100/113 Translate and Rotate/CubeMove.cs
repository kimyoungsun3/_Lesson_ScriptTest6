using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour {
	
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward);
	}
}
