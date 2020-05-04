using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _171_LineRenderer
{
	public class EnemyBat : MonoBehaviour
	{
		int lineCount = 4;
		[SerializeField] LineRenderer lineRenderer;
		[SerializeField] Transform target;
		Vector3[] linePos;

		Transform trans;
		Vector3 beforePos;
		Quaternion beforeRot;

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

				linePos[0] = trans.position;
				Vector3 _dir = target.position - trans.position;
				linePos[1] = trans.position + _dir * 0.2f;
				linePos[2] = trans.position + _dir * 0.8f;
				linePos[3] = trans.position + _dir + _dir * 0.2f;

				lineRenderer.SetPositions(linePos);
			}
		}
	}
}