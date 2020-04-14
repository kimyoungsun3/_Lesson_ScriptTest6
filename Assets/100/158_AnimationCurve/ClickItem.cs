using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _158_AnimationCurve
{
	public class ClickItem : MonoBehaviour
	{
		[SerializeField] AnimationCurve curve;
		[SerializeField] float duration = 1f;
		Coroutine co;
		public void MoveLerp(Vector3 _pos)
		{
			if (co != null)
			{
				StopCoroutine(co);
			}
			co = StartCoroutine(Co_MoveLerp(_pos, duration));
		}

		IEnumerator Co_MoveLerp(Vector3 _endPos, float _duration)
		{
			Transform _t		= transform;
			Vector3 _startPos	= _t.position;
			float _speed	= 1f / _duration;
			float _percent	= 0;
			float _i;
			//Debug.Log("s:" + Time.time);
			while (_percent < 1f)
			{
				_percent += _speed * Time.deltaTime;
				_i = curve.Evaluate(_percent);
				_t.position = Vector3.Lerp(_startPos, _endPos, _i);
				yield return null;
			}
			//Debug.Log("e:" + Time.time);
		}
	}
}