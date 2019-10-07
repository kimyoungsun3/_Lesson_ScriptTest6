using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _146_VectorTest
{
	public class VectorTest : MonoBehaviour
	{
		private void Start()
		{
			Debug.Log("1, 2");
		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				FunAnglue();	
			}
			else if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				FunClampMagnitude();
			}


			Debug.DrawLine(Vector3.zero, from, Color.blue);
			Debug.DrawLine(Vector3.zero, to, Color.red);

			Debug.DrawLine(Vector3.zero, clampVector, Color.green);
			Debug.DrawLine(Vector3.right, Vector3.right + clampVectorResult, Color.green);
		}

		[Header("Vector Angle (1 key)")]
		[SerializeField] Vector3 from	= Vector3.forward;
		[SerializeField] Vector3 to		= Vector3.right;
		void FunAnglue() { 
			float _dot = Vector3.Dot(from.normalized, to.normalized);
			_dot = Mathf.Clamp(_dot, -1f, 1f);

			Debug.Log("Vecotor3.Angle -> "
				+ Mathf.Acos(_dot) * Mathf.Rad2Deg);
		}

		[Space]
		[Header("ClampMagnitude (2 key)")]
		public Vector3 clampVector = new Vector3(10, 10, 10);
		public Vector3 clampVectorResult;
		public float clampLength = 2f;
		void FunClampMagnitude()
		{
			clampVectorResult = (clampVector.sqrMagnitude <= clampLength * clampLength
				? clampVector 
				: clampVector.normalized * clampLength);
           
		}

		public Vector3 MoveTowards(Vector3 _current, Vector3 _target, float _maxDistanceDelta)
		{
			Vector3 _moveDelta;
			Vector3 _dir	= _target - _current;
			float _distance = _dir.magnitude;
			_moveDelta = (_distance <= _maxDistanceDelta || _distance < 1.401298E-45f 
				? _target : _current + ((_dir / _distance) * _maxDistanceDelta));
			return _moveDelta;
		}


	}
}
