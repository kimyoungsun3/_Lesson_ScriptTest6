using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Material _m = GetComponent<MeshRenderer>().sharedMaterial;
		_m.color = Color.red;
	}
}
