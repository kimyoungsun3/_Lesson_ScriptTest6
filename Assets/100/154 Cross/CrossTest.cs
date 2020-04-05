using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrossTest
{
	public class CrossTest : MonoBehaviour
	{
		[SerializeField] Transform target;
		[SerializeField] UILabel msg;


		private void OnDrawGizmos()
		{
			if (target == null) return;

			Gizmos.color = Color.blue;
			Gizmos.DrawRay(transform.position, transform.forward);

			Gizmos.color = Color.red;
			Gizmos.DrawLine(transform.position, target.position);


			Gizmos.color = Color.green;
			Vector3 _dir = target.position - transform.position;
			Vector3 _cross = Vector3.Cross(transform.forward, _dir.normalized);

			Gizmos.DrawRay(transform.position, _cross);

			msg.text = "cross:" + _cross 
				+"\n dot:" + Vector3.Dot(Vector3.up, _cross.normalized);
		}
	}

}