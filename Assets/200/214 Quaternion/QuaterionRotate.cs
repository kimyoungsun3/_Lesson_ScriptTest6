using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuaterionTest{
	public class QuaterionRotate : MonoBehaviour {
		public float turnSpeed = 30f;

		void Start(){
			Debug.Log ("Arrow Left, Right, Up, Down, I, O Rotate > Quaterion Value Change");
		}

		void Update () {
			if (Input.GetKeyDown (KeyCode.R)) {
				transform.rotation = Quaternion.identity;
			}

			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.Rotate (-Vector3.up * turnSpeed * Time.deltaTime);
			} else if (Input.GetKey (KeyCode.RightArrow)) {
				transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime);
			} 

			if (Input.GetKey (KeyCode.UpArrow)) {
				transform.Rotate (Vector3.right * turnSpeed * Time.deltaTime);
			} else if (Input.GetKey (KeyCode.DownArrow)) {
				transform.Rotate (-Vector3.right * turnSpeed * Time.deltaTime);
			}

			if (Input.GetKey (KeyCode.I)) {
				transform.Rotate (Vector3.forward * turnSpeed * Time.deltaTime);
			} else if (Input.GetKey (KeyCode.O)) {
				transform.Rotate (-Vector3.forward * turnSpeed * Time.deltaTime);
			}
			
		}
	}
}
