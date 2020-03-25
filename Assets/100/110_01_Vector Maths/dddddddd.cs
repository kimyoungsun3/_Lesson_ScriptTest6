using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dddddddd : MonoBehaviour {

	public Transform target;
	public float speedTurn = 30f;

	private void Update()
	{
		Vector3 _dir		= target.position - transform.position;
		Quaternion _dirQ	= Quaternion.LookRotation(_dir);

		//transform.rotation = _dirQ;
		transform.rotation = Quaternion.RotateTowards(
			transform.rotation,
			_dirQ,
			speedTurn * Time.deltaTime);
	}

	private void OnDrawGizmos()
	{
		//if (target == null) return;

		//Vector3 _dir = target.position - transform.position;
		//Vector3 _forward = transform.forward;

		////Debug.Log(Vector3.Dot(_forward, _dir) 
		////	+ ":" + Vector3.Angle(_forward, _dir.normalized));

		//Vector3 _axis = Vector3.Cross(_forward, _dir.normalized);
		//Vector3 _up = Vector3.up;
		//float _lr = Vector3.Dot(_axis, _up);
		//if (_lr >= 0)
		//	Debug.Log(">>");
		//else
		//	Debug.Log("<<");

		//Gizmos.DrawRay(transform.position, _axis);

	}
}
