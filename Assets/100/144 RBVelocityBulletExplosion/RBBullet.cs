using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RBVelocityTest
{
	public class RBBullet : MonoBehaviour
	{
		public Rigidbody bulletShellPrefab;
		public Transform spawnPoint;
		public float power = 200f;
		float nextTime;
		public float NEXT_TIME = 0.2f;

		// Update is called once per frame
		void Update()
		{
			float _h = Input.GetAxis("Horizontal");
			float _v = Input.GetAxis("Vertical");
			if(_h != 0)
				transform.Rotate(Vector3.up * _h * Time.deltaTime * 180);
			if (_v != 0)
				transform.Translate(Vector3.forward * _v * Time.deltaTime * 3f);



			if (Input.GetMouseButton(0) && Time.time > nextTime)
			{
				nextTime = Time.time + NEXT_TIME;

				Rigidbody _rb = Instantiate(bulletShellPrefab, spawnPoint.position, spawnPoint.rotation) as Rigidbody;
				_rb.AddForce(spawnPoint.forward * power);
				_rb.AddTorque(Random.onUnitSphere);

				Destroy(_rb.gameObject, 3f);
			}
			else if (Input.GetMouseButtonDown(1))
			{
				NEXT_TIME = NEXT_TIME * .8f;
				NEXT_TIME = NEXT_TIME < 0.05f ? 0.05f : NEXT_TIME;
			}
		}
	}
}