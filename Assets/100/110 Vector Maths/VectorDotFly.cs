using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VectorTest{
	public class VectorDotFly : MonoBehaviour {
		public float speed = 30f;
		void Start () {
			Debug.Log ("Up/Down arrow");	
		}
		
		// Update is called once per frame
		void Update () {
			float _updown = 0;
			if (Input.GetKey (KeyCode.UpArrow)) {
				_updown = Time.deltaTime * speed;
			} else if (Input.GetKey (KeyCode.DownArrow)) {
				_updown = -Time.deltaTime * speed;
			}

			transform.Rotate (Vector3.right * _updown);

			float _dot = Vector3.Dot (transform.forward, Vector3.up);
			Debug.Log (_dot);
		}


		//-------------------
		void OnDrawGizmos(){
			Gizmos.color = Color.blue;
			Gizmos.DrawRay (transform.position, transform.forward * 3f);

			Gizmos.color = Color.green;
			Gizmos.DrawRay (transform.position, Vector3.up * 3f);

		}
	}
}
