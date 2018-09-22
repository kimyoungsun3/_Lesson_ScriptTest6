using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComponentTest{
	public class ChangeColor : MonoBehaviour {
		Renderer renderer;

		void Start(){
			renderer = GetComponent<Renderer> ();
			Debug.Log ("push key R, G and B");
		}


		// Update is called once per frame
		void Update () {
			if (Input.GetKeyDown (KeyCode.R)) {
				renderer.material.color = Color.red;
			} else if (Input.GetKeyDown (KeyCode.G)) {
				renderer.material.color = Color.green;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				renderer.material.color = Color.blue;
			}
		}
	}
}
