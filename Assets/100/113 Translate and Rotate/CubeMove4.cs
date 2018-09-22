using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TranslateAndRotate{
	public class CubeMove4 : MonoBehaviour {
		public float moveSpeed = 2f;
		void Start () {
			Debug.Log ("키보드의 W,S 또는 상하 키로 전방 이동해보세요.");
		}

		// Update is called once per frame
		void Update () {

			if (Input.GetKey (KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
				transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
				transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
			}
		}
	}
}