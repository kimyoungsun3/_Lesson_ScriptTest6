﻿using System.Collections;
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
			if (Input.GetKeyDown (KeyCode.A)) {
				Debug.Log (this + " press a");
			}
		}
	}

}
