using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace _412_Event
{
	public class CubeEventTest : MonoBehaviour
	{

		[SerializeField] UICamera uiCamera;
		Material material;
		Color colorOrginal;
		void Start()
		{
			material = GetComponent<Renderer>().material;
			colorOrginal = material.color;
		}


		void Update()
		{
			Touch _tourch;
			if (Input.touchCount < 1 || (_tourch = Input.GetTouch(0)).phase != TouchPhase.Began)
			{
				return;
			}
			if (EventSystem.current.IsPointerOverGameObject(_tourch.fingerId)
						   || uiCamera == UICamera.currentCamera)
			{
				//Debug.Log(1);
				return;
			}

			if (Input.GetMouseButtonUp(0))
			{
				Debug.Log("GetMouseButtonUp:" + this);
			}
		}

		bool bRed;
		void OnMouseUp()
		{
			Debug.Log("OnMouseUp : " + this);
			bRed = !bRed;
			material.color = bRed ? Color.red : Color.white;
		}

		//void OnMouseEnter(){
		//	Debug.Log ("OnMouseUp : " + name);
		//	mat.color = Color.red;
		//}

		//void OnMouseOver(){
		//	Debug.Log ("OnMouseUp : " + name);
		//	mat.color = Color.green;
		//}

		//void OnMouseExit(){
		//	Debug.Log ("OnMouseUp : " + name);
		//	mat.color = colorOrginal;
		//}
	}

}