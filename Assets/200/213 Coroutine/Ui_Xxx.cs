using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void VOID_FUN_VOID3(string _str);
public class Ui_Xxx : MonoBehaviour {
	VOID_FUN_VOID3 onUpdate;

	public void InvokeEventRegister(VOID_FUN_VOID3 _on){
		onUpdate = _on; 
	}

	void OnMouseDown(){
		if (onUpdate != null) {
			onUpdate (gameObject.name);
		}
	}
}
