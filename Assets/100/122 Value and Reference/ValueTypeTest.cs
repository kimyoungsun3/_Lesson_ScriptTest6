using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ValueAndReference{
	public class ValueTypeTest : MonoBehaviour {

		void Start () {
			int x1 = 1;
			int x2 = x1;
			x2 *= 10;
			Debug.Log (x1 + " > " + x2);

			Debug.Log ("--- Value Type V3 ---");	
			Vector3 _d1 = new Vector3 (1, 2, 3);
			Vector3 _d2 = _d1; // copy value..
			_d2 *= 10;
			Debug.Log (_d1 + " , " + _d2);

			Debug.Log ("--- Value Type Quaterion ---");	
			Quaternion _q1 = transform.rotation;
			Quaternion _q2 = _q1; // copy value..
			//_q2 = _q2 * _d2;
			//Debug.Log (_q1 + " , " + _q2);
			_q2 = _q1 * Quaternion.Euler(Vector3.up * 90);
			Debug.Log (_q1 + " , " + _q2);

		}

		void Update(){

		}

	}
}
