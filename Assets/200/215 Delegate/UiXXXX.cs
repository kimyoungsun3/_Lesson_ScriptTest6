using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void VOID_FUN_VOID();
public class UiXXXX : MonoBehaviour {
	VOID_FUN_VOID onClick;
	public void UnVisible(){
		gameObject.SetActive (false);
	}
	public void SetVisible(VOID_FUN_VOID _on){
		onClick = _on;
		gameObject.SetActive (true);
	}
	public void InvokeOk(){
		if (onClick != null) {
			onClick ();
			onClick = null;
		}
		gameObject.SetActive (false);
	}
}
