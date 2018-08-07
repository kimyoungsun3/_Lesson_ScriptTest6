using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle2 : MonoBehaviour {


	//-----------------------
	void Awake(){
		Debug.Log (this + " Awake");
	}
	void OnEnable () {
		Debug.Log (this + " OnEnable");		
	}

	//-----------------------
	void Start () {
		Debug.Log (this + " Start");		
	}

	//------------------------
	void FixedUpdate () {
		Debug.Log (this + " FixedUpdate");		
	}
	void Update () {
		Debug.Log (this + " Update");		
	}
	void LateUpdate () {
		Debug.Log (this + " LateUpdate");		
	}

	//------------------------
	void OnDisable () {
		Debug.Log (this + " OnDisable");		
	}
}
