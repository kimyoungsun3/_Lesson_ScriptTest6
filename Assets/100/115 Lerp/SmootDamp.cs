using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lerp{
	public class SmootDamp : MonoBehaviour {
		public float moveTime;
		public Transform target;
		Vector3 sp;
		
		// Update is called once per frame
		void Update () {
			transform.position = Vector3.SmoothDamp (transform.position, target.position, ref sp, moveTime);
		}
	}
}
