using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace VectorTest{
	public class VectorAddOffset: MonoBehaviour {
		public Transform p1, p2;

		void OnDrawGizmos(){
			if (p1 != null && p2 != null) {
				Gizmos.color = Color.red;
				Gizmos.DrawLine (Vector3.zero, p1.position);
				Gizmos.DrawLine (p2.position, p2.position + p1.position);

				Gizmos.color = Color.green;
				Gizmos.DrawLine (Vector3.zero, p2.position);
				Gizmos.DrawLine (p1.position, p1.position + p2.position);

				Gizmos.color = Color.blue;
				Gizmos.DrawLine (Vector3.zero, p1.position + p2.position);
			}
		}
	}
}
