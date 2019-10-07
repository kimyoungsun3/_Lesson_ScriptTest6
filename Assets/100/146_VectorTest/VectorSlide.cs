using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _146_VectorTest
{
	public class VectorSlide : MonoBehaviour
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
				Vector3 _project = Project(-_dir, _normal);
				Gizmos.color = Color.blue;
				Gizmos.DrawLine(_hit.point, _hit.point + _project);
				
				Vector3 _projectH = -ProjectOnPlane(-_dir, _normal);
				Gizmos.color = Color.green;
				Gizmos.DrawLine(_hit.point + _project, _hit.point + _project + _projectH);

				Vector3 _reflect = Reflect(_dir, _normal);
				Gizmos.color = Color.gray;
				Gizmos.DrawLine(_hit.point, _hit.point + _reflect);
			}

			//Gizmos.color = Color.green;
			//Gizmos.DrawLine(Vector3.zero, p2.position);
		}

		public Vector3 Project(Vector3 _header, Vector3 _railDir)
		{
			Vector3 _project;
			float _dot = Vector3.Dot(_railDir, _railDir);
			_project = (_dot >= Mathf.Epsilon
				? (_railDir * Vector3.Dot(_header, _railDir)) / _dot
				: Vector3.zero);
			return _project;
		}

		public Vector3 ProjectOnPlane(Vector3 _header, Vector3 _railDir)
		{
			return _header - Project(_header, _railDir);
		}

		public Vector3 Reflect(Vector3 _inDirection, Vector3 _inNormal)
		{
			Vector3 _reflect = (-2f * Vector3.Dot(_inDirection, _inNormal) * _inNormal) + _inDirection;
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