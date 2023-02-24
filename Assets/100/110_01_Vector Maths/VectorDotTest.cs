using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VectorTest
{
	public class VectorDotTest : MonoBehaviour
	{
		public Text text;
		public Transform target;

		private void OnDrawGizmos()
		{
			if(target != null)
			{
				Vector3 _dir1 = transform.up;
				Vector3 _dir2 = (target.position - transform.position).normalized;
				float _dot = Vector3.Dot(_dir1, _dir2);

				Gizmos.color = Color.red;
				Gizmos.DrawRay(transform.position, _dir1);

				Gizmos.color = Color.green;
				Gizmos.DrawRay(transform.position, _dir2);

				Gizmos.color = Color.blue;
				Gizmos.DrawRay(transform.position, _dir2 * _dot);


				text.text  = Vector3.Dot(_dir1, _dir2).ToString() + "\n";
				text.text += Vector3.Angle(_dir1, _dir2).ToString() + "\n";
				text.text += Angle(_dir1, _dir2).ToString();
			}
		}

		float Angle(Vector3 _dir1, Vector3 _dir2)
		{
			return Mathf.Acos(Vector3.Dot(_dir1, _dir2)) * Mathf.Rad2Deg;
		}
	}
}