using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TranslateAndRotate{
	public class CubeMove3 : MonoBehaviour {
		public float moveSpeed = 2f;

		// Update is called once per frame
		void Update () {
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}
	}
}