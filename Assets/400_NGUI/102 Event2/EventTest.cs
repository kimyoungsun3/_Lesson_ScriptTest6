﻿using UnityEngine;
using System.Collections;

namespace _412_Event
{
	public class EventTest : MonoBehaviour
	{
		/*
		void OnHover(bool _isOver){
			if (_isOver) {
				Debug.Log ("Hover over " + name);
				GetComponent<Renderer> ().material.color = Color.red;
			} else {
				Debug.Log ("Hoover away from " + name);
				GetComponent<Renderer> ().material.color = Color.green;
			}
		}
		*/
		Material material;
		Color colorOrginal;
		void Start()
		{
			material = GetComponent<Renderer>().material;
			colorOrginal = material.color;
		}

		bool bBlue;
		void OnPress(bool _isPressed)
		{
			//Debug.Log ("OnPress : " + this + ":" + UICamera.current);
			//isPressed = _isPressed;
			//point = new Vector3(UICamera.lastHit.point.x, UICamera.lastHit.point.y, transform.position.z);
			if (_isPressed)
			{
				bBlue = !bBlue;
				material.color = bBlue ? Color.blue : Color.white;
			}
		}

		//bool bRed;
		//void OnMouseUp(){
		//	Debug.Log ("OnMouseUp : " + this);
		//	bRed = !bRed;
		//	mat.color = bRed?Color.red:Color.white;
		//}

		//void Update(){
		//	if (Input.GetMouseButtonUp (0)) {
		//		Debug.Log ("GetMouseButtonUp : " + this);
		//	}
		//}


		//bool isPressed = false;
		//Vector3 point;
		//public bool bClickPointMove = false;
		//void Update(){
		//	if (isPressed && bClickPointMove) {
		//		transform.position = point;
		//	}
		//}

		//void OnClick(){
		//	Debug.Log ("Clicked on " + name);
		//	GetComponent<Spin>().enabled = !GetComponent<Spin>().enabled;
		//}
	}
}