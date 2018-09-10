using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GetAxisTest{
	public class InputGetAxisRaw : MonoBehaviour {
		public float range = 5f;
		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {
			float h = Input.GetAxisRaw ("Horizontal") * range;	
			float v = Input.GetAxisRaw ("Vertical") * range;
			Debug.Log (h + ":" + v);

			transform.position = new Vector3 (h, v, transform.position.z);
		}
	}
}