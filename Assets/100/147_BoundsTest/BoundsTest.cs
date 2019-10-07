using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _147_BoundsTest
{

	public class BoundsTest : MonoBehaviour
	{
		[SerializeField] Transform p1, p2;
		[SerializeField] UILabel text;
		[SerializeField] float skinWidth = 0.015f;
		private void OnDrawGizmos()
		{
			if (p1 == null) return;


			Vector3 _size	= (p2.position - p1.position);
			Vector3 _center	= p1.position + _size / 2f;
			_160_UnityEngineTest.Bounds_.Bounds _bounds = new _160_UnityEngineTest.Bounds_.Bounds(_center, _size);
			string _str = "";


			Gizmos.color = Color.red;
			_str += "1>>" + _bounds.center + ":" + _bounds.extents;
			Gizmos.DrawWireCube(_bounds.center, _bounds.extents*2f);


			Gizmos.color = Color.green;
			_bounds.Expand(2f*skinWidth);
			_str += "\n2>>" + _bounds.center + ":" + _bounds.extents;
			//DrawWireCube(_bounds.center, _bounds.extents);
			Gizmos.DrawWireCube(_bounds.center, _bounds.extents * 2f);

			text.text = _str;
		}

		void DrawWireCube(Vector3 _center, Vector3 _extends)
		{
			Vector3 _p0		= _center - _extends;
			Vector3 _p2		= _center + _extends;
			Vector3 _p1		= new Vector3(_p2.x, _p0.y, 0);
			Vector3 _p3		= new Vector3(_p0.x, _p2.y, 0);
			Gizmos.DrawLine(_p0, _p2);
			Gizmos.DrawLine(_p0, _p1);
			Gizmos.DrawLine(_p1, _p2);
			Gizmos.DrawLine(_p2, _p3);
			Gizmos.DrawLine(_p3, _p0);
		}
	}
}
