using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _115_SmoothDamp
{
	public class SmoothDampTest : MonoBehaviour
	{
		Transform trans;
		[SerializeField] float backValue = 2f;
		[SerializeField] float moveTime = 0.2f;
		[SerializeField] bool bUnity3dVector = true;
		Vector3 dummySpeed;
		Vector3 next;
		void Start()
		{
			trans = transform;
		}

		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				next = trans.position + trans.forward * backValue;
			}

			if (bUnity3dVector)
				trans.position = Vector3.SmoothDamp(trans.position, next, ref dummySpeed, moveTime);
			else
				trans.position = SmoothDamp(trans.position, next, ref dummySpeed, moveTime);
		}

		public static Vector3 SmoothDamp(Vector3 _current, Vector3 _target, ref Vector3 _currentVelocity, float _dampingTime, float _maxSpeed)
		{
			float _deltaTime = Time.deltaTime;
			return Vector3.SmoothDamp(_current, _target, ref _currentVelocity, _dampingTime, _maxSpeed, _deltaTime);
		}

		//[ExcludeFromDocs]
		public static Vector3 SmoothDamp(Vector3 _current, Vector3 _target, ref Vector3 _currentVelocity, float _dampingTime)
		{
			float _deltaTime = Time.deltaTime;
			float _maxSpeed = float.PositiveInfinity;
			return Vector3.SmoothDamp(_current, _target, ref _currentVelocity, _dampingTime, _maxSpeed, _deltaTime);
		}

		public static Vector3 SmoothDamp(Vector3 _current, Vector3 _target, ref Vector3 _currentVelocity, float _dampingTime, float _maxSpeed, float _deltaTime)
		{
			_dampingTime		= Mathf.Max(0.0001f, _dampingTime);
			float _rsoothTime	= 2f / _dampingTime;
			float single1		= _rsoothTime * _deltaTime;
			float single2		= 1f / (1f + single1 + 0.48f * single1 * single1 + 0.235f * single1 * single1 * single1);
			Vector3 _dir		= _current - _target;
			Vector3 _targetPos	= _target;

			_dir = Vector3.ClampMagnitude(_dir, _maxSpeed * _dampingTime);
			_target = _current - _dir;
			Vector3 vector32 = (_currentVelocity + (_rsoothTime * _dir)) * _deltaTime;
			_currentVelocity = (_currentVelocity - (_rsoothTime * vector32)) * single2;
			Vector3 vector33 = _target + ((_dir + vector32) * single2);
			if (Vector3.Dot(_targetPos - _current, vector33 - _targetPos) > 0f)
			{
				vector33 = _targetPos;
				_currentVelocity = (vector33 - _targetPos) / _deltaTime;
			}
			return vector33;
		}
	}
}
