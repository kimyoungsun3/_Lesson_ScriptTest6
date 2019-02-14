using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MovementTest
{
	public class MoveTransform2 : MonoBehaviour
	{
		Transform trans;
		public float speedMove = 2f;
		public float speedTurn = 180f;

		void Start()
		{
			trans = transform;
		}

		// Update is called once per frame
		void FixedUpdate()
		{
			float _h = Input.GetAxis("Horizontal");
			float _v = Input.GetAxis("Vertical");

			trans.Translate(_v * Vector3.forward * speedMove * Time.deltaTime);
			trans.Rotate(_h * Vector3.up * speedTurn * Time.deltaTime);
		}
	}
}