using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GetAxisTest{
	public class InputGetAxis2 : MonoBehaviour {
		public float range = 5f;
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			//float h = Input.GetAxis ("Horizontal") * range;	
			//float v = Input.GetAxis ("Vertical") * range;
			Vector3 move = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0f);
			Debug.Log ("1:" + move);
			move = move.normalized ;
			Debug.Log ("2:" + move);
			move = move * range;

			Debug.Log ("3:" + move);
			move.z = transform.position.z;

			//transform.position = new Vector3 (h, v, transform.position.z);
			transform.position = move;
		}
	}
}