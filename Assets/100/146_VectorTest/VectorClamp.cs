using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _146_VectorTest
{
	public class VectorClamp : MonoBehaviour
	{
		public Transform p0, p1;
		public UILabel text;
		public float radius = 5f;

		private void OnDrawGizmos()
		{
			if (p0 == null) return;

			Gizmos.color = Color.red;
			Gizmos.DrawLine(p0.position, p1.position);

			Vector3 _dir1 = p1.position - p0.position;
			_dir1 = ClampMagnitude(_dir1, radius);
			Gizmos.color = Color.green;
			Gizmos.DrawLine(p0.position, p0.position + _dir1);

			text.text = "Clamp:" + radius;
		}

		Vector3 ClampMagnitude(Vector3 _dir, float _radius)
		{
			_dir = (_dir.sqrMagnitude <= _radius * _radius
				? _dir
				: _dir.normalized * _radius);

			return _dir;
		}
	}
}
