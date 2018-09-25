using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InstantiateTest{
	public class PlayerController_GameObject : MonoBehaviour {
		public GameObject bulletPrefab;
		public Transform spawnPoint;
		public float moveSpeed = 3;
		public float turnSpeed = 90;

		
		// Update is called once per frame
		void Update () {
			float forwardMovement = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
			float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

			transform.Translate(Vector3.forward * forwardMovement);
			transform.Rotate(Vector3.up * turnMovement);

			if (Input.GetMouseButtonDown (0)) {
				GameObject _t = Instantiate (bulletPrefab, spawnPoint.position, spawnPoint.rotation) as GameObject;
				Rigidbody _rb = _t.GetComponent<Rigidbody> (); 
				_rb.AddForce (_t.transform.forward * 500);

				Destroy (_t.gameObject, 2f);
			}
		}
	}
}
