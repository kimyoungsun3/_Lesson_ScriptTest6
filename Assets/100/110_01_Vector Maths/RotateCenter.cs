using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VectorTest{
	public class RotateCenter : MonoBehaviour {
		public Transform target;
		public float rotateSpeed = 2f;
		public float speed = 2f;
		
		// Update is called once per frame
		void Update () {
			//transform.RotateAround (target.position, Vector3.up, rotateSpeed * Time.deltaTime);	
			Vector3 _dir = target.position - transform.position;
			Quaternion _dirQ = Quaternion.LookRotation(_dir);
			Quaternion _dirMy = transform.rotation;
			transform.rotation = Quaternion.Lerp(_dirMy, _dirQ, rotateSpeed * Time.deltaTime);
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
	}
}