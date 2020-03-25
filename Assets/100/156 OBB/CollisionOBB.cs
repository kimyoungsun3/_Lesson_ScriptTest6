using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OBBTest
{
	public class CollisionOBB : MonoBehaviour
	{
		[SerializeField] Renderer a;
		[SerializeField] Renderer b;
		private void OnDrawGizmos()
		{
			if (a == null || b == null) return;

			Vector3 _ax = a.transform.right;
			Vector3 _ay = a.transform.up;
			Vector3 _az = a.transform.forward;

			Vector3 _bx = b.transform.right;
			Vector3 _by = b.transform.up;
			Vector3 _bz = b.transform.forward;

			Vector3 _dir = b.transform.position - a.transform.position;

			Vector3 _x = Vector3.right;

		}
	}
}
