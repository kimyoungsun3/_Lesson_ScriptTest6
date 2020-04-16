using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _161_QuationEulerDir
{
	public class QED2: MonoBehaviour
	{
		[SerializeField] int count = 10;
		[SerializeField] Transform p1, p2;
		[SerializeField] List<Transform> target = new List<Transform>();
		private void OnDrawGizmos()
		{
			if(p1 != null && p2 != null && target.Count >= count)
			{
				Vector3 _dir = p2.position - p1.position;
				Vector3 _dirN = _dir.normalized;
				float _angleY = Mathf.Atan2(_dirN.z, _dirN.x) * Mathf.Rad2Deg;
				target[0].eulerAngles = new Vector3(0, 90f - _angleY, 0);

				_angleY = 90 - (90f - _angleY);
				target[1].forward = new Vector3(
					Mathf.Cos(_angleY * Mathf.Deg2Rad),
					0,
					Mathf.Sin(_angleY * Mathf.Deg2Rad));
			}
		}
	}
}