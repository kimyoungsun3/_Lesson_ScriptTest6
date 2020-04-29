using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace _190_UiTest
{
	public class UiAndObjectFilter : MonoBehaviour
	{
		Renderer renderer;
		Color colorOri;

		private void Start()
		{
			renderer = GetComponent<Renderer>();
			colorOri = renderer.material.color;
		}

		private void OnMouseEnter()
		{
			if (EventSystem.current.IsPointerOverGameObject()															//pc
				|| (Input.touchCount > 0 && EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))	//mobile
				|| IsPointerOverUIObject())																				//pc and mobile
				return;

			renderer.material.color = Color.green;
		}

		private void OnMouseDown()
		{
			if (EventSystem.current.IsPointerOverGameObject()                                                           //pc
				|| (Input.touchCount > 0 && EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))    //mobile
				|| IsPointerOverUIObject())                                                                             //pc and mobile
				return;

			renderer.material.color = Color.red;
		}

		private void OnMouseExit()
		{
			renderer.material.color = colorOri;
		}

		void Update()
		{
			if ( ( Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
				|| ( Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began &&  EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId ) ) ){
					//renderer.material.color = Color.red;
			}
		}

		//----------------------------------
		PointerEventData eventDataCurrentPosition;
		List<RaycastResult> results = new List<RaycastResult>();
		private bool IsPointerOverUIObject()
		{
			if (eventDataCurrentPosition == null) eventDataCurrentPosition = new PointerEventData(EventSystem.current);
			eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
			return results.Count > 0;
		}
	}
}
