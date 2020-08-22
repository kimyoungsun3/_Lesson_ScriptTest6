using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _146_VectorTest
{
	public class VectorAngle : MonoBehaviour
	{
		public Transform p0, p1, p2;
		public UILabel text;
		//int count = 0;

		private void OnDrawGizmos()
		{
			//Debug.Log(this + ":" + count++);
			if (p2 == null) return;

			Vector3 _dir1 = p1.position - p0.position;
			Vector3 _dir2 = p2.position - p0.position;

			Gizmos.color = Color.red;
			Gizmos.DrawLine(p0.position, p1.position);
			Gizmos.DrawLine(p0.position, p2.position);

			Gizmos.color = Color.green;
			Gizmos.DrawLine(p0.position, p0.position + _dir1.normalized);
			Gizmos.DrawLine(p0.position, p0.position + _dir2.normalized);

			text.text = "Dot : " + Vector3.Dot(_dir1.normalized, _dir2.normalized);
			text.text += "\nAngle : " + Angle(_dir1, _dir2);
		}

		float Angle(Vector3 _from, Vector3 _to)
		{
			float _dot = Vector3.Dot(_from.normalized, _to.normalized);
			_dot = Mathf.Clamp(_dot, -1f, 1f);
			return Mathf.Acos(_dot) * Mathf.Rad2Deg;
		}

	}
}
