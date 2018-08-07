using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lerp{
	public class LerpMove : MonoBehaviour {
		public float interSpeed;
		public Transform target;
		void Update () {
			transform.position = Vector3.Lerp (transform.position, target.position, interSpeed * Time.deltaTime);
		}
	}
}
