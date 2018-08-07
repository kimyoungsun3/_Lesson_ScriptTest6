using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour {
	delegate void VOID_FUN_INT(int _x);
	VOID_FUN_INT callbackFun;


	void Start () {
		Debug.Log ("각각 처리");
		callbackFun = PrintNum;
		callbackFun (5);

		callbackFun = PrintNum2;
		callbackFun (5);


		Debug.Log ("콜백한꺼번에 처리");
		callbackFun = PrintNum;
		callbackFun += PrintNum2;
		callbackFun (5);

	}


	void PrintNum(int _x){
		Debug.Log (_x);
	}

	void PrintNum2(int _x){
		Debug.Log (_x * 2);
	}


}
