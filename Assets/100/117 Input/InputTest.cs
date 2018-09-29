using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InputTest{
	public class InputTest : MonoBehaviour {

		// Use this for initialization
		void Start () {
			Debug.Log ("Press A key");
		}
		
		// Update is called once per frame
		void Update () {

			Debug.Log(
				"A GetKeyDown:" + Input.GetKeyDown(KeyCode.A)
				+ " GetKey:" + Input.GetKey(KeyCode.A)
				+ " GetKey:" + Input.GetKeyUp(KeyCode.A)
			);
		}
	}

}
