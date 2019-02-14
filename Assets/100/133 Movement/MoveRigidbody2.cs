using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MovementTest
{
	public class MoveRigidbody2 : MonoBehaviour
	{
		Transform trans;
		Rigidbody rb;
		public float speedMove = 2f;
		public float speedTurn = 180f;

		void Start()
		{
			trans = transform;
			rb = GetComponent<Rigidbody>();
		}

		// Update is called once per frame
		void FixedUpdate()
		{
			float _h = Input.GetAxis("Horizontal");
			float _v = Input.GetAxis("Vertical");

			rb.MovePosition(rb.position + _v * trans.forward * speedMove * Time.deltaTime);
			rb.MoveRotation(rb.rotation * Quaternion.Euler(_h * Vector3.up * speedTurn * Time.deltaTime));
		}
	}
}