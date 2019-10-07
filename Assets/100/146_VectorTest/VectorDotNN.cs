using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _146_VectorTest
{
	public class VectorDotNN : MonoBehaviour
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


			float _dot		= 0;
			float _angle	= 0;
			_dot	= Vector3.Dot(_dir1.normalized, _dir2.normalized);
			_angle	= Mathf.Acos(_dot) * Mathf.Rad2Deg;
			text.text = "V3.Dot(n,n) Cos Radius:" + _dot
				+ "\n angle(자체):" + _angle
				+ "\n angle(V3):" + Angle(_dir1, _dir2)
				+ "\n SignedAngle(V3):" + SignedAngle(_dir1, _dir2, Vector3.right);

			Gizmos.color = Color.green;
			Gizmos.DrawLine(p0.position, p0.position + _dot * _dir1.normalized);
			Gizmos.DrawLine(p0.position, p0.position + _dot * _dir2.normalized);

		}

		float Angle(Vector3 _from, Vector3 _to)
		{
			Vector3 _fromNormal = _from.normalized;
			Vector3 _toNormal	= _to.normalized;
			float _angle = Mathf.Acos(Mathf.Clamp(Vector3.Dot(_fromNormal, _toNormal), -1f, 1f)) * Mathf.Rad2Deg;
			return _angle;
		}

		float SignedAngle(Vector3 _from, Vector3 _to, Vector3 _axis)
		{
			Vector3 _fromNormal	= _from.normalized;
			Vector3 _toNormal	= _to.normalized;
			float _angle	= Mathf.Acos(Mathf.Clamp(Vector3.Dot(_fromNormal, _toNormal), -1f, 1f)) * Mathf.Rad2Deg;
			float _sign		= Mathf.Sign(Vector3.Dot(_axis, Vector3.Cross(_fromNormal, _toNormal)));
			return _angle * _sign;
		}
	}
}