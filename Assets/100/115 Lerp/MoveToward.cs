using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lerp{
	public class MoveToward : MonoBehaviour {
		public float speed;
		public Transform target;
		
		// Update is called once per frame
		void Update () {
			transform.position = Vector3.MoveTowards (transform.position, target.position, speed * Time.deltaTime);
		}
	}
}