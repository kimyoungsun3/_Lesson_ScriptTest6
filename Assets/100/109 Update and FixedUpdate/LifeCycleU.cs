using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycleU : MonoBehaviour {


	void Update () {
		Debug.Log ("Update :" + Time.deltaTime);	
	}


	void FixedUpdate () {
		Debug.Log ("FixedUpdate :" + Time.deltaTime);	
	}
}
