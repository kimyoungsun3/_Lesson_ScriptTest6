using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _151_TransformTest
{
	public class TransformDirectionTest : MonoBehaviour
	{
		[SerializeField] UILabel label;
		[SerializeField] Vector3 dir = new Vector3(1, 2, 3);
		[Header("===========> Result")]
		[SerializeField] Vector3 dir1;
		[SerializeField] Vector3 dir2, dir3;

		//[Header("==============")]
		//[SerializeField] Transform t21;


		private void OnDrawGizmos()
		{
			Gizmos.color = Color.red;
			dir1 = transform.right * dir.x
				+ transform.up * dir.y
				+ transform.forward * dir.z;
			Gizmos.DrawLine(transform.position, transform.position + dir1);

			Gizmos.color = Color.green;
			dir2 = transform.TransformDirection(dir);
			Gizmos.DrawLine(transform.position, transform.position + dir2);

			Gizmos.color = Color.blue;
			dir3 = transform.rotation * dir;
			Gizmos.DrawLine(transform.position, transform.position + dir3);
		}
	}
}
