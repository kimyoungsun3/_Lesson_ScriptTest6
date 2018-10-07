using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DelegateTest{
	public class DelegateTest : MonoBehaviour {
		VOID_FUN_INT cbFun;


		void Start () {
			Debug.Log ("각각 처리");
			cbFun = OnPrintNum;
			cbFun (5);

			cbFun = OnPrintNum2;
			cbFun (5);


			Debug.Log ("콜백한꺼번에 처리");
			cbFun  = OnPrintNum;
			cbFun += OnPrintNum2;
			cbFun (5);

		}

		void OnPrintNum(int _x){
			Debug.Log (_x);
		}

		void OnPrintNum2(int _x){
			Debug.Log (_x * 2);
		}
	}
}
