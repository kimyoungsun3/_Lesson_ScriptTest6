using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GetAxisTest{
	public class InputGetAxisRaw2 : MonoBehaviour {
		public float range = 5f;
		Vector3 move;

		void Start () {

		}

		// Update is called once per frame
		void Update () {
			//float h = Input.GetAxis ("Horizontal") * range;	
			//float v = Input.GetAxis ("Vertical") * range;
			Vector3 move = new Vector3 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"), 0f);
			move = move.normalized * range;
			move.z = transform.position.z;

			//transform.position = new Vector3 (h, v, transform.position.z);
			transform.position = move;




		}
	}
}