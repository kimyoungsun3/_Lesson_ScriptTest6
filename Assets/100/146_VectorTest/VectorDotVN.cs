using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _146_VectorTest
{
	public class VectorDotVN : MonoBehaviour
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


			float _dot			= 0;
			Vector3 _dir2Normal = _dir2.normalized;
			_dot				= Vector3.Dot(_dir1, _dir2Normal);
			text.text = "V3.Dot(V,N) >> Project(Len) :" + _dot;

			Gizmos.color = Color.green;
			Gizmos.DrawLine(p0.position, p0.position + _dot * _dir2Normal);
		}
	}
}