using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DeltaTimeTest
{
	public class DeltaTimeCompare3 : MonoBehaviour
	{
		public eUpdateType kind = eUpdateType.Update;
		public float speed = 2f;
		public float turnSpeed = 180f;
		float v, h;

		private void Start()
		{
			Debug.Log(this + " move " + kind);
		}

		void Update()
		{
			v = Input.GetAxisRaw("Vertical");
			h = Input.GetAxisRaw("Horizontal"); 

			if (kind == eUpdateType.Update)
			{
				transform.Translate(v * Vector3.forward * speed * Time.deltaTime);
				transform.Rotate(h * Vector3.up * turnSpeed * Time.deltaTime);
			}
		}

		private void FixedUpdate()
		{
			if (kind == eUpdateType.FixedUpdate)
			{
				transform.Translate(v * Vector3.forward * speed * Time.fixedDeltaTime);
				transform.Rotate(h * Vector3.up * turnSpeed * Time.deltaTime);
			}
		}
	}
}
