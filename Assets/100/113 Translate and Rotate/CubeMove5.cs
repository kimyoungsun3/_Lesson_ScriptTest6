using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TranslateAndRotate{
	public class CubeMove5 : MonoBehaviour {
		public float turnSpeed = 30f;
		public float moveSpeed = 2f;
		void Start () {
			Debug.Log ("ASDW is Move and Rotate / rotate -> move");
			Debug.Log ("회전 -> 이동과 이동을 하고 회전은 미묘한 차이가 발생한다.");
		}

		// Update is called once per frame
		void Update () {
			if (Input.GetKey (KeyCode.A)) {
				transform.Rotate (-Vector3.up * turnSpeed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.D)) {
				transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime);
			}

			if (Input.GetKey (KeyCode.W)) {
				transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.S)) {
				transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
			}
		}
	}
}