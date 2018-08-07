using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObject : MonoBehaviour {
	public string discription;
	public GameObject goTarget;

	void Start(){

		Debug.Log (goTarget.name);
		Debug.Log ("activeSelf:" + goTarget.activeSelf);
		Debug.Log ("activeInHierarchy:" + goTarget.activeInHierarchy);
	}
}
