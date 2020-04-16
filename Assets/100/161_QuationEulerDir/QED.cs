using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _161_QuationEulerDir
{
	public class QED : MonoBehaviour
	{
		[SerializeField] Transform p1, p2;
		[SerializeField] List<Transform> target = new List<Transform>();
		private void OnDrawGizmos()
		{
			if(p1 != null && p2 != null && target.Count >= 10)
			{
				Vector3 _dir = p2.position - p1.position;
				Quaternion _dirQ = Quaternion.identity;
				if (_dir != Vector3.zero)
					_dirQ = Quaternion.LookRotation(_dir);				
				target[0].rotation		= _dirQ;
				target[1].eulerAngles	= _dirQ.eulerAngles;
				target[2].rotation		= Quaternion.Euler(_dirQ.eulerAngles);
				target[3].forward		= _dir.normalized;
				target[4].forward		= Quaternion.Euler(_dirQ.eulerAngles) * Vector3.forward;
			}
		}
	}
}