using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VectorTest{
	public class VectorMinus : MonoBehaviour {
		public Transform p1, p2;
		Vector3 p;

		void OnDrawGizmos(){
			if (p1 != null && p2 != null) {
				Gizmos.color = Color.red;
				Gizmos.DrawLine (Vector3.zero, p1.position);

				Gizmos.color = Color.green;
				Gizmos.DrawLine (Vector3.zero, p2.position);

				Gizmos.color = Color.blue;
				Vector3 _dir = p2.position - p1.position;
				Gizmos.DrawLine (Vector3.zero, _dir);
			}
		}
	}
}
