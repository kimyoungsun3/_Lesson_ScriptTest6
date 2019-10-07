using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _146_VectorTest
{
	public class VectorSlide2 : MonoBehaviour
	{
		[SerializeField] Transform p1;

		private void OnDrawGizmos()
		{
			Ray _ray = new Ray(transform.position, transform.right);
			RaycastHit _hit;
			if(Physics.Raycast(_ray, out _hit))
			{
				Vector3 _hitPoint	= _hit.point;
				Vector3 _hitNormal	= _hit.normal;
				Vector3 _dir		= _hitPoint - transform.position;

				Gizmos.color = Color.red;
				Gizmos.DrawLine(transform.position, _hit.point);

				Gizmos.color = Color.blue;
				Vector3 _project = Project(-_dir, _hitNormal);
				Gizmos.DrawLine(_hitPoint, _hitPoint + _project);

				Vector3 _projectH = ProjectOnPlane(-_dir, _hitNormal);
				Gizmos.color = Color.white;
				Gizmos.DrawLine(_hitPoint + _project, _hitPoint + _project + _projectH);

				Gizmos.color = Color.green; 
				Gizmos.DrawLine(_hitPoint + _project, _hitPoint + _project - _projectH);

				Gizmos.color = Color.gray;
				Vector3 _reflect = Reflect(_dir, _hitNormal);
				Gizmos.DrawLine(_hitPoint, _hitPoint + _reflect);
			}
		}

		Vector3 Project(Vector3 _dir, Vector3 _onNormal)
		{
			Vector3 _project;
			float _dot = Vector3.Dot(_onNormal, _onNormal);

			_project = (_dot >= Mathf.Epsilon)
				? (Vector3.Dot(_dir, _onNormal) * _onNormal) / _dot
				: Vector3.zero;

			return _project;
		}

		Vector3 ProjectOnPlane(Vector3 _dir, Vector3 _planeNormal)
		{
			return _dir - Project(_dir, _planeNormal);
		}

		Vector3 Reflect(Vector3 _inDirection, Vector3 _inNormal)
		{
			Vector3 _reflect;
			_reflect = _inDirection + (-2f * Vector3.Dot(_inDirection, _inNormal)) * _inNormal;
			return _reflect;
		}
	}
}