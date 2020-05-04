using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _171_LineRenderer
{
	public class EnemyArrow : MonoBehaviour
	{
		[SerializeField] LayerMask mask;
		[SerializeField] int lineCount = 5;
		[SerializeField] LineRenderer lineRenderer;
		Vector3[] linePos;

		Transform trans;
		Vector3 beforePos;
		Quaternion beforeRot;
		Ray ray;

		void Start()
		{
			trans = transform;
			lineRenderer.positionCount = lineCount;
			linePos = new Vector3[lineCount];
		}

		void Update()
		{
			if (trans.position != beforePos || trans.rotation != beforeRot)
			{
				beforePos = trans.position;
				beforeRot = trans.rotation;

				RaycastHit _hit;
				ray.origin = trans.position;
				ray.direction = trans.forward;

				linePos[0] = trans.position;
				for (int i = 1, imax = lineCount; i < imax; i++)
				{
					if (Physics.Raycast(ray, out _hit, 100, mask))
					{
						linePos[i] = _hit.point;

						ray.origin = _hit.point;
						ray.direction = Vector3.Reflect(ray.direction, _hit.normal);
					}
				}

				lineRenderer.SetPositions(linePos);
			}
		}
	}
}