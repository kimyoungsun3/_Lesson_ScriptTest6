using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ValueAndReference{
	public class ValueTypeTest : MonoBehaviour {
		Ray ray3;
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

			Ray _ray = new Ray ();
			_ray.origin = Vector3.one;
			_ray.direction = Vector3.one;
			Ray _ray2 = _ray;
			_ray2.origin *= 10;
			_ray2.direction *= 10;
			Debug.Log (_ray.origin + ":" + _ray2.origin);
			Debug.Log (_ray.direction + ":" + _ray2.direction);
			//New, new아닌것... 설명
			//RaycastHit
			//Ray ray4;
			//Debug.Log (ray4.origin);
			//int x ;
			//Debug.Log (x);
			//RaycastHit hit;
			//Debug.Log (hit);


		}

		/*
		Vector3 v = Vector3.one;
		void Update(){
			if (Input.GetMouseButtonDown (0)) {
				DDD (v);
			}
			Debug.Log (v);
		}

		void DDD(Vector3 _v){
			_v *= 10;
		}
		*/

	}
}
