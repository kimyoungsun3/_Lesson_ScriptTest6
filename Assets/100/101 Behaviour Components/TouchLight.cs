using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchLight : MonoBehaviour {
	public Renderer renderer;
	public Material mat;


	void Start(){
		renderer = GetComponent<Renderer> ();
		mat = renderer.material;
		Debug.Log ("push key R, G and B");
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			mat.color = Color.red;
		} else if (Input.GetKeyDown (KeyCode.G)) {
			mat.color = Color.green;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			mat.color = Color.blue;
		}
		//Debug.Log (Input.inputString);
	}

}
