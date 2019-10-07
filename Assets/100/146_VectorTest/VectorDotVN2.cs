using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _146_VectorTest
{
	public class VectorDotVN2 : MonoBehaviour
	{
		public Transform p0, p1, p2;
		public UILabel text;

		void OnDrawGizmos()
		{
			if (p0 == null)
				return;

			Vector3 _dir1 = p1.position - p0.position;
			Vector3 _dir2 = p2.position - p0.position;
			Gizmos.color = Color.red;
			Gizmos.DrawLine(p0.position, p1.position);
			Gizmos.DrawLine(p0.position, p2.position);

						
			Vector3 _project = Vector3.Project(_dir1, _dir2); //(V,N : 안에서 바뀜)
			text.text = "V3.Project(V,N)\n >> " + _project;

			Gizmos.color = Color.green;
			Gizmos.DrawLine(p0.position, p0.position + _project);
		}
	}
}