using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueReference : MonoBehaviour {

	void Start () {
		Debug.Log ("--- Value Type V3 ---");	
		Vector3 _d1 = new Vector3 (1, 2, 3);
		Vector3 _d2 = _d1; // copy value..
		_d2 *= 10;
		Debug.Log (_d1 + " , " + _d2);

		Debug.Log ("--- Value Type Quaterion ---");	
		Quaternion _q1 = transform.rotation;
		Quaternion _q2 = _q1; // copy value..
		_q2 = _q1 * Quaternion.Euler(Vector3.up * 90);
		Debug.Log (_q1 + " , " + _q2);

		Debug.Log ("--- Reference Type Script(V3) ---");	
		VR _scp1 = GetComponent<VR> ();
		VR _scp2 = _scp1;
		_scp1.v = new Vector3 (1, 2, 3);
		_scp2.v *= 10;
		Debug.Log (_scp1.v + " , " + _scp2.v);

		Debug.Log ("--- Reference Type Script(Quaternion) ---");	
		_scp1.q = Quaternion.identity;
		_scp2.q = Quaternion.Euler(Vector3.up * 90);
		Debug.Log (_scp1.q + " , " + _scp2.q);

		//x = transform.position.x = 1.0f;
	}

}
