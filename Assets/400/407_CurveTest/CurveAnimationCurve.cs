using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CurveTest
{
	public class CurveAnimationCurve : MonoBehaviour
	{
		public AnimationCurve curve;
		public Transform cube;
		public Transform p1;

		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				StartCoroutine(Co_Move());
			}
		}

		IEnumerator Co_Move()
		{
			float _speed = 2f;
			float _t = 0f;
			float _y;
			Vector3 _pos = cube.position;
			Vector3 _p1 = p1.position;
			while (_t < 1f)
			{
				_t += Time.deltaTime * _speed;
				_y = curve.Evaluate(_t);
				cube.position = Vector3.Lerp(_pos, _p1, _y);
				yield return null;
			}
		}
	}
}