using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TranslateAndRotate{
	public class CubeMove6 : MonoBehaviour {
		public float turnSpeed = 30f;
		public float moveSpeed = 2f;
		void Start () {
			Debug.Log ("ASDW is Move and Rotate/ move -> rotate");
		}

		// Update is called once per frame
		void Update () {
			if (Input.GetKey (KeyCode.W)) {
				transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.S)) {
				transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
			}

			if (Input.GetKey (KeyCode.A)) {
				transform.Rotate (-Vector3.up * turnSpeed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.D)) {
				transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime);
			}
		}
	}
}