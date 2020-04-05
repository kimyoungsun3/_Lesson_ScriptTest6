using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrossTest
{
	public class TargetAroundMove : MonoBehaviour
	{
		[SerializeField] Transform target;
		[SerializeField] bool bPause;

		private void OnDrawGizmos()
		{
			if (target == null || bPause) return;

			transform.RotateAround(target.position, Vector3.up, 10f * Time.deltaTime);
		}
	}
}