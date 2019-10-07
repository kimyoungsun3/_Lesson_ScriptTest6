using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void VOID_FUN_VOID();
namespace DelegateTest
{
	public class UiXXXX : MonoBehaviour
	{
		VOID_FUN_VOID onClick;
		[SerializeField] GameObject bodyGo;
		private void Awake()
		{
			//Debug.Log(this + " Start");
			bodyGo.SetActive(false);
		}

		public void SetVisible(VOID_FUN_VOID _on)
		{
			Debug.Log(this + " SetVisible");
			bodyGo.SetActive(true);
			onClick = _on;
		}

		public void InvokeOk()
		{
			if (onClick != null)
			{
				onClick();
				onClick = null;
			}
			bodyGo.SetActive(false);
		}

		public void InvokeNo()
		{
			if (onClick != null)
			{
				onClick();
				onClick = null;
			}
			bodyGo.SetActive(false);
		}
	}
}