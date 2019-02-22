using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RBVelocityTest
{
	public class RBVelocity : MonoBehaviour
	{
		public float speed;
		Rigidbody rb;
		Vector3 posOrigin;
		Quaternion rotOrigin;
		void Start()
		{
			rb = GetComponent<Rigidbody>();
			rb.isKinematic = true;

			posOrigin = transform.position;
			rotOrigin = transform.rotation;
		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				rb.isKinematic = false;
				rb.velocity = transform.forward * speed;
			}
			else if (Input.GetMouseButtonDown(1))
			{
				rb.isKinematic = true;
				transform.position = posOrigin;
				transform.rotation = rotOrigin;
			}
		}
	}

}