using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorDotDirection : MonoBehaviour {
	Transform playerTarget;

	void Start(){
		playerTarget = GameObject.FindGameObjectWithTag ("Player").transform;
	}


	void Update () {
		Vector3 _dirView = (playerTarget.position - transform.position);
		Vector3 _dirNormal = _dirView.normalized;
		float _dot = Vector3.Dot (transform.forward, _dirNormal);
		if(_dot > .5f)
			Debug.Log ("forward:" + _dot);
		else if(_dot > -.5f)
			Debug.Log ("side:" + _dot);
		else
			Debug.Log ("back:" + _dot);
	}
}
