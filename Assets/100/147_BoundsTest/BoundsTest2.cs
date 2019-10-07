using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _147_BoundsTest
{

	public class BoundsTest2 : MonoBehaviour
	{
		[SerializeField] Transform p1, p2;
		[SerializeField] UILabel text;
		[SerializeField] float skinWidth = 0.015f;
		Vector3 bottomLeft, bottomRight, topLeft, topRight;
		[SerializeField][Range(2, 10)] int countX = 4;
		[SerializeField] [Range(2, 10)] int countY = 4;
		float intervalX, intervalY;
		private void OnDrawGizmos()
		{
			if (p1 == null) return;


			Vector3 _size	= (p2.position - p1.position);
			Vector3 _center	= p1.position + _size / 2f;
			_160_UnityEngineTest.Bounds_.Bounds _bounds 
				= new _160_UnityEngineTest.Bounds_.Bounds(_center, _size);
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

			//Recalculate....
			bottomLeft.Set(_bounds.min.x, _bounds.min.y, 0);
			bottomRight.Set(_bounds.max.x, _bounds.min.y, 0);
			topLeft.Set(_bounds.min.x, _bounds.max.y, 0);
			topRight.Set(_bounds.max.x, _bounds.max.y, 0);

			//line count...
			float _dx = _bounds.max.x - _bounds.min.x;
			intervalX = _dx / (countX - 1);
			float _dy = _bounds.max.y - _bounds.min.y;
			intervalY = _dy / (countY - 1);

			Gizmos.color = Color.red;
			VerticleDraw(bottomLeft, -1f);
			VerticleDraw(topLeft, +1f);
			HorizontalDraw(bottomLeft, -1f);
			HorizontalDraw(bottomRight, +1f);



		}

		void VerticleDraw(Vector3 _startPos, float _dir)
		{
			Vector3 _pos;
			for (int x = 0; x < countX; x++)
			{
				_pos = _startPos + Vector3.right * intervalX * x;
				Gizmos.DrawRay(_pos, _dir * Vector3.up);
			}
		}

		void HorizontalDraw(Vector3 _startPos, float _dir)
		{
			Vector3 _pos;
			for (int y = 0; y < countY; y++)
			{
				_pos = _startPos + Vector3.up * intervalY * y;
				Gizmos.DrawRay(_pos, _dir * Vector3.right);
			}
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
