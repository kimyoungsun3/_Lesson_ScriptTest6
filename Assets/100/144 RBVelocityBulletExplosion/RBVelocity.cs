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

			beforePos = transform.position;
			Debug.Log(rotOrigin);
		}

		Vector3 beforePos;
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
				transform.rotation = rotOrigin;
				transform.position = posOrigin;
				Debug.Log(rotOrigin);
			}

			//해당 방향으로 바라보기...
			Vector3 _dir = transform.position - beforePos;
			if(_dir != Vector3.zero)
			{
				transform.rotation = Quaternion.FromToRotation(Vector3.forward, _dir);
			}
			beforePos = transform.position;
		}
	}

}