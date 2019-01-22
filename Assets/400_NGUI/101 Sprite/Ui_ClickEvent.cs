using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NGUI_101_ClickEvent
{
	public class Ui_ClickEvent : MonoBehaviour
	{
		public GameObject target;
		public void InvokeToggle()
		{
			if(target != null)
			{
				target.SetActive(!target.activeSelf);
			}

		}

		public void InvokeToggle2(GameObject _target)
		{
			if (_target != null)
			{
				_target.SetActive(!_target.activeSelf);
			}

		}
	}
}
