using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TranslateAndRotate{
	public class CubeMove4 : MonoBehaviour {
		public float moveSpeed = 2f;
		void Start () {
			Debug.Log ("WS is Move");
		}

		// Update is called once per frame
		void Update () {

			if (Input.GetKey (KeyCode.W)) {
				transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.S)) {
				transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
			}
		}
	}
}