using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _161_QuationEulerDir
{
	public class QED3: MonoBehaviour
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
				float _angleZ = Mathf.Atan2(_dirN.y, _dirN.x) * Mathf.Rad2Deg;
				target[0].eulerAngles = new Vector3(0, 0, _angleZ);


				target[1].right = new Vector3(
					Mathf.Cos(_angleZ * Mathf.Deg2Rad),
					Mathf.Sin(_angleZ * Mathf.Deg2Rad),
					0);
			}
		}
	}
}