using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeltaTimeTest{
	public class DeltaTimeYes : MonoBehaviour {
		public float moveSpeed = 2f;
		
		// Update is called once per frame
		void Update () {
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}
	}
}
