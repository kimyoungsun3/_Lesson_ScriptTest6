using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void VOID_FUN_VOID2();

public class DelegateOrder : MonoBehaviour {

	void Start () {
		VOID_FUN_VOID2 callback;

		callback  = OnFun1;
		callback += OnFun2;
		callback += OnFun3;
		if (callback != null) {
			callback ();
		}

		callback  = OnFun3;
		callback += OnFun2;
		callback += OnFun1;
		if (callback != null) {
			callback ();
		}

		callback  = OnFun3;
		callback += OnFun2;
		callback += OnFun2;
		callback += OnFun2;
		callback += OnFun1;
		if (callback != null) {
			callback ();
		}
	}

	void OnFun1(){
		Debug.Log ("OnFun1");
	}
	void OnFun2(){
		Debug.Log ("OnFun2");
	}
	void OnFun3(){
		Debug.Log ("OnFun3");
	}
	
}
