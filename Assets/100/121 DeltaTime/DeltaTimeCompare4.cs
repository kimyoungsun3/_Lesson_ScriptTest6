using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DeltaTimeTest
{
	public class DeltaTimeCompare4 : MonoBehaviour
	{
		[SerializeField] eUpdateType kind = eUpdateType.Update;
		[SerializeField] float speed = 2f;
		[SerializeField] float turnSpeed = 180f;
		float v, h;
		[SerializeField] Rigidbody rb;

		private void Start()
		{
			if (rb == null)
				rb = GetComponent<Rigidbody>();
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
				//transform.Translate(v * Vector3.forward * speed * Time.fixedDeltaTime);
				//transform.Rotate(h * Vector3.up * turnSpeed * Time.deltaTime);

				//rb.MovePosition(rb.position + v * speed * rb.transform.forward * Time.deltaTime);
				//rb.MoveRotation(rb.rotation * (h * Vector3.up * turnSpeed * Time.deltaTime));
			}
		}
	}
}
