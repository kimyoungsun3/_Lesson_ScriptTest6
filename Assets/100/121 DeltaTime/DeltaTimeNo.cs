using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeltaTimeTest{
	public class DeltaTimeNo : MonoBehaviour {
		public float moveSpeed = 2f;
		Vector3 move;
		
		// Update is called once per frame
		void Update () {
			transform.Translate (Vector3.forward * moveSpeed);
		}
	}
}