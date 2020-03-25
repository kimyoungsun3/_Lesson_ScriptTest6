using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VectorTest{
	public class RotateCenter : MonoBehaviour {
		public Transform target;
		public float rotateSpeed;
		
		// Update is called once per frame
		void Update () {
			transform.RotateAround (target.position, Vector3.up, rotateSpeed * Time.deltaTime);	
		}
	}
}