using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Destroy{
	public class XXXX : MonoBehaviour {
		public float speed = 3f;
		public void InvokeMove(){
			StartCoroutine (CoMove ());
		}

		IEnumerator CoMove(){
			while (true) {
				transform.Translate (Vector3.forward * speed * Time.deltaTime);
				yield return null;
			}
		}
	}
}
