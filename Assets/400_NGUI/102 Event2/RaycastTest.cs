using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace _412_Event
{
	public class RaycastTest : MonoBehaviour
	{

		[SerializeField] UICamera uiCamera;
		Ray ray;
		RaycastHit hit;
		void Update()
		{

			//UI를 클릭시 return한다...
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

			ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit))
			{
				Debug.Log("camera:" + UICamera.current);
			}
		}
	}
}
