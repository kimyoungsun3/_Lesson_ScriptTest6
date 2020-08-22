using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _189_RigidbodyTest
{

	public class MoveRigidbody : MonoBehaviour
	{
		public float speed;
		Rigidbody rigidbody;
		float v;
		void Start()
		{
			rigidbody = GetComponent<Rigidbody>();
		}

		// Update is called once per frame
		void Update()
		{
			float _v = Input.GetAxisRaw("Vertical");

			if(_v != 0)
			{
				rigidbody.velocity = transform.forward * speed;
			}
			else if(v != 0)
			{
				rigidbody.velocity = Vector3.zero;
			}
			v = _v;
		}
	}
}
