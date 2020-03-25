using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _151_TransformTest
{
	public class TransformPointTest : MonoBehaviour
	{
		[SerializeField] UILabel label;
		[SerializeField] Vector3 dir = new Vector3(1, 2, 3);
		[Header("===========> Result")]
		[SerializeField] Vector3 dir2;
		[SerializeField] Vector3 offset = new Vector3(1, 0, 0);

		//[Header("==============")]
		//[SerializeField] Transform t21;


		private void OnDrawGizmos()
		{
			Gizmos.color = Color.green;
			dir2 = transform.TransformPoint(dir);
			Gizmos.DrawLine(offset + transform.position, offset + transform.position + dir2);

		}
	}
}
