using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _146_VectorTest
{
	public class VectorReflect : MonoBehaviour
	{
		[SerializeField] Transform p1;


		private void OnDrawGizmos()
		{
			Ray _ray = new Ray(p1.position, p1.right);
			RaycastHit _hit;
			if (Physics.Raycast(_ray, out _hit))
			{
				Gizmos.color = Color.red;
				Gizmos.DrawLine(p1.position, _hit.point);
				Vector3 _dir	= _hit.point - p1.position;
				Vector3 _normal = _hit.normal;
				Vector3 _reflecct = Reflect(_dir, _normal);
				Gizmos.color = Color.blue;
				Gizmos.DrawLine(_hit.point, _hit.point + _reflecct);
			}

			//Gizmos.color = Color.green;
			//Gizmos.DrawLine(Vector3.zero, p2.position);
		} 


		public Vector3 Reflect(Vector3 _inDirection, Vector3 _inNormal)
		{
			Vector3 _reflect = (-2f * Vector3.Dot(_inNormal, _inDirection) * _inNormal) + _inDirection;
			return _reflect;
		}

		//public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
		//{
		//	Vector3 vector3;
		//	Vector3.INTERNAL_CALL_RotateTowards(ref current, ref target, maxRadiansDelta, maxMagnitudeDelta, out vector3);
		//	return vector3;
		//}

	}

}