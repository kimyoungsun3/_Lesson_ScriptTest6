using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLookAt2 : MonoBehaviour {
	public Transform transTarget;

	void Update () {
		if (transTarget != null) {
			transform.LookAt (transTarget);	
		}
	}
}
