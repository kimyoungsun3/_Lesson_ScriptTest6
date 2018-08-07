using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QTest : MonoBehaviour {

	public Transform target;
	public Quaternion q1, q2;


	void Update () {
		q1 = transform.rotation;
		q2 = target.rotation;

		if (Input.GetKey (KeyCode.Alpha1)) {
			target.rotation = Quaternion.LookRotation (transform.forward);//, Vector3.up);
		} else if (Input.GetKey (KeyCode.Alpha2)) {
			target.rotation = Quaternion.Euler (transform.eulerAngles);
		
		} else if (Input.GetKey (KeyCode.Alpha3)) {
			target.rotation = Quaternion.FromToRotation (Vector3.forward, -transform.forward);
		} else if (Input.GetKey (KeyCode.Alpha4)) {
			target.rotation = Quaternion.FromToRotation (-transform.forward, Vector3.forward);//X
		} else if (Input.GetKey (KeyCode.Alpha5)) {
			target.rotation = Quaternion.FromToRotation (Vector3.up, -transform.up);
		} else if (Input.GetKey (KeyCode.Alpha6)) {
			target.rotation = Quaternion.FromToRotation (-transform.up, Vector3.up);
		} else if (Input.GetKey (KeyCode.Alpha7)) {
			target.rotation = Quaternion.FromToRotation (Vector3.right, -transform.right);
		} else if (Input.GetKey (KeyCode.Alpha8)) {
			target.rotation = Quaternion.FromToRotation (-transform.right, Vector3.right);
		}
	}
}
