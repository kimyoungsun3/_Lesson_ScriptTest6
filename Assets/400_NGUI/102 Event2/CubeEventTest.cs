using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeEventTest : MonoBehaviour {

	Material mat;
	Color colorOrginal;
	void Start(){
		mat = GetComponent<Renderer> ().material;
		colorOrginal = mat.color;
	}


	void Update(){
		if (Input.GetMouseButtonUp (0)) {
			Debug.Log ("GetMouseButtonUp:" + this);
		}
	}

	bool bRed;
	void OnMouseUp(){
		Debug.Log ("OnMouseUp : " + this);
		bRed = !bRed;
		mat.color = bRed?Color.red:Color.white;
	}

	/*
	void OnMouseEnter(){
		Debug.Log ("OnMouseUp : " + name);
		mat.color = Color.red;
	}

	void OnMouseOver(){
		Debug.Log ("OnMouseUp : " + name);
		mat.color = Color.green;
	}

	void OnMouseExit(){
		Debug.Log ("OnMouseUp : " + name);
		mat.color = colorOrginal;
	}
	*/
}

