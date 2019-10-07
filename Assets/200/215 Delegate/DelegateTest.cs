using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DelegateTest{
	public class DelegateTest : MonoBehaviour {
		VOID_FUN_INT onFun;
		VOID_FUN_INT onFun2;

		void Start () {
			Debug.Log ("--각각 처리--");
			onFun = OnPrintNum;
			onFun (1);

			onFun = OnPrintNum2;
			onFun (2);


			Debug.Log ("--콜백한꺼번에 처리--");
			onFun  = OnPrintNum;
			onFun += OnPrintNum2;
			onFun (5);

			Debug.Log("--Action2 <- Action--");
			onFun2 = onFun;
			if (onFun2 != null)
				onFun2(11);

		}

		void OnPrintNum(int _x){
			Debug.Log ("OnPrintNum:" + _x);
		}

		void OnPrintNum2(int _x)
		{
			Debug.Log("OnPrintNum2:" + _x);
		}
	}
}
