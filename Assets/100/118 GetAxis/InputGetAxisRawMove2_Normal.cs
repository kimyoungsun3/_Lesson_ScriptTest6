using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GetAxisTest{
	public class InputGetAxisRawMove2_Normal : MonoBehaviour {
		public float moveSpeed = 2f;

		// Update is called once per frame
		void Update () {
			float _h = Input.GetAxisRaw ("Horizontal");	
			float _v = Input.GetAxisRaw ("Vertical");
			Vector3 _move = new Vector3 (_h, 0, _v);

			transform.Translate (_move.normalized * moveSpeed * Time.deltaTime);
		}
	}
}