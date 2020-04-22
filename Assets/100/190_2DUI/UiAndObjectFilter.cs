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
			if (EventSystem.current.IsPointerOverGameObject())
				return;
			renderer.material.color = Color.green;
		}

		private void OnMouseExit()
		{
			renderer.material.color = colorOri;
		}
	}
}
