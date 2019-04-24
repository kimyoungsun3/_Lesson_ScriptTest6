using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EquationTestNameSpace
{
	public class EquationTest : MonoBehaviour
	{
		public float duration = 200f;
		public Transform p1, p2;
		Transform trans;
		void Start()
		{
			trans = transform;
		}

		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				StopAllCoroutines();
				StartCoroutine(Co_Attack());
			}
		}

		IEnumerator Co_Attack()
		{
			float _speed = 1000f / duration;
			float _x = 0;
			float _y = 0;
			Vector3 _p1 = p1.position;
			Vector3 _p2 = p2.position;
			
			while (_x < 1f)
			{
				_x += _speed * Time.deltaTime;
				_y = -4 * (_x - 0.5f) * (_x - 0.5f) + 1;
				trans.position = Vector3.Lerp(_p1, _p2, _y);
				yield return null;
			}
		}
	}
}
