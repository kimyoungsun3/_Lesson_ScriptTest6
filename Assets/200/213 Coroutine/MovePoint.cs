using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _213_Coroutine
{
	public class MovePoint : MonoBehaviour
	{
		[SerializeField] bool bCoRoutine;
		[SerializeField] float speed;
		[SerializeField] List<Vector3> wayPointLocal = new List<Vector3>();
		List<Vector3> wayPoint = new List<Vector3>();
		void Start()
		{
			for(int i = 0, imax = wayPointLocal.Count; i < imax; i++)
			{
				wayPoint.Add(transform.TransformPoint(wayPointLocal[i]));
			}
			StartCoroutine("Co_MovePoint");
		}

		IEnumerator Co_MovePoint()
		{
			Transform _t = transform;
			int _idx = 0;
			Vector3 _pos = wayPoint[ _idx ];
			while (bCoRoutine)
			{
				if(_pos == _t.position)
				{
					_idx = (_idx + 1) % wayPoint.Count;
					_pos = wayPoint[_idx];
				}

				_t.position = Vector3.MoveTowards(_t.position, _pos, speed * Time.deltaTime);
				yield return null;
			}
		}

		private void OnMouseDown()
		{
			bCoRoutine = !bCoRoutine;
			if (bCoRoutine)
			{
				StopAllCoroutines();
				StartCoroutine("Co_MovePoint");
			}
		}

#if UNITY_EDITOR
		private void OnDrawGizmos()
		{
			if (wayPointLocal.Count >= 2)
			{
				Gizmos.color = Color.white;
				for (int i = 0, imax = wayPointLocal.Count - 1; i < imax; i++)
				{
					Gizmos.DrawLine(transform.TransformPoint(wayPointLocal[i]), transform.TransformPoint(wayPointLocal[i + 1]));
				}
			}
		}
#endif
	}
}