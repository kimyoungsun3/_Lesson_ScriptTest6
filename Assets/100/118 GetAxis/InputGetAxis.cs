using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GetAxisTest{
	public class InputGetAxis : MonoBehaviour {
		public float range = 5f;
		
		// Update is called once per frame
		void Update () {
			float h = Input.GetAxis ("Horizontal") * range;	
			float v = Input.GetAxis ("Vertical") * range;

			transform.position = new Vector3 (h, v, transform.position.z);
		}
	}
}