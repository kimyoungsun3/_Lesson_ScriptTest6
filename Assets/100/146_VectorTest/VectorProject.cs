using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _146_VectorTest
{
	public class VectorProject : MonoBehaviour
	{
		[SerializeField] Transform p0, p1, p2;
		[SerializeField] UILabel txtProject, txtProjectH, txtReflect;


		private void OnDrawGizmos()
		{
			if (p0 == null) return;

			Vector3 _dir1 = p1.position - p0.position;
			Vector3 _dir2 = p2.position - p0.position;
			Vector3 _p0 = p0.position;

			Gizmos.color = Color.red;
			Gizmos.DrawLine(p0.position, p1.position);
			Gizmos.DrawLine(p0.position, p2.position);

			Gizmos.color = Color.green;
			//Vector3 _project = Project(_dir1, _dir2.normalized);
			Vector3 _project = Project(_dir1, _dir2);
			Gizmos.DrawLine(_p0, _p0 + _project);
			txtProject.text = "Project" 
				+ "\n (a,b) >> " + Vector3.Project(_dir1, _dir2)
				+ "\n (a,bN) >> " + Project(_dir1, _dir2);

			Gizmos.color = Color.blue;
			//Vector3 _projectOne = ProjectOnPlane(_dir1, _dir2.normalized);
			Vector3 _projectOne = ProjectOnPlane(_dir1, _dir2);
			Gizmos.DrawLine(p0.position + _project, p0.position + _project + _projectOne);
			txtProjectH.text = "ProjectH"
				+ "\n (a,b) >> " + Vector3.ProjectOnPlane(_dir1, _dir2)
				+ "\n (a,bN) >> " + ProjectOnPlane(_dir1, _dir2.normalized);

			Gizmos.color = Color.gray;
			Vector3 _reflect = Reflect(-_dir1, _dir2.normalized);
			Gizmos.DrawLine(p0.position, p0.position + _reflect);
			txtReflect.text = "Reflect"
				+ "\n(-a,bN) >> " + Reflect(-_dir1, _dir2.normalized)
				+ "\n(-a, b)" + Vector3.Reflect(-_dir1, _dir2);
		}

		//void Slide(Transform target, Vector3 railDirection)
		//{
		//	Vector3 heading = target.position - transform.position;
		//	Vector3 force = Vector3.Project(heading, railDirection);
		//	GetComponent<Rigidbody>().AddForce(force);
		//}

		//나무의 그림자 -> Project
		//레일 바라보는???
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
			return _header - Vector3.Project(_header, _railDir);
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