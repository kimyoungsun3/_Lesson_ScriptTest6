using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VectorTest{
	public class VectorGizmos : MonoBehaviour {
		public float radius = 1f;

		//-------------------
		void OnDrawGizmos(){
			Gizmos.color = Color.red;
			Gizmos.DrawRay (transform.position, transform.right * radius);

			Gizmos.color = Color.green;
			Gizmos.DrawRay (transform.position, transform.up * radius);

			Gizmos.color = Color.blue;
			Gizmos.DrawRay (transform.position, transform.forward * radius);

		}
	}
}