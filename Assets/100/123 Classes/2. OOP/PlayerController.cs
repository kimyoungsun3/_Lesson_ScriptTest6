using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassesTest2{
	public class PlayerController : MonoBehaviour {
		public float speed;
		public float turnSpeed;

		public void Movement ()
		{
			float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
			float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

			transform.Translate(Vector3.forward * forwardMovement);
			transform.Rotate(Vector3.up * turnMovement);
		}
	}
}