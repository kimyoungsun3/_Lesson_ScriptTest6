using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoQu : MonoBehaviour {
	public float angle1;
	public float angle2;
	public bool bApple = false;

	void Start(){
		angle1 = transform.eulerAngles.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (bApple) {
			Quaternion rotation2 = Quaternion.Euler (Vector3.up * angle2);
			transform.rotation = transform.rotation * rotation2;
			bApple = false;
		}
	}
}
