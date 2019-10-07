using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _146_VectorTest
{
	public class VectorUnLerp : MonoBehaviour
	{
		[SerializeField] Transform p1, p2, p3;
		[SerializeField] [Range(-1, 2)] float interval;

		private void OnDrawGizmos()
		{
			if (p1 == null) return;

			p3.position = Vector3.LerpUnclamped(p1.position, p2.position, interval);
		}
	}
}