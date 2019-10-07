using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DelegateTest{
	public class DelegateOrder : MonoBehaviour {

		void Start () {
			VOID_FUN_VOID2 _on;

			_on  = OnFun1;
			_on += OnFun2;
			_on += OnFun3;
			Debug.Log("*** 1-2-3 ***");
			if (_on != null) {
				_on ();
			}

			_on  = OnFun3;
			_on += OnFun2;
			_on += OnFun1;
			Debug.Log("*** 3-2-1 ***");
			if (_on != null) {
				_on ();
			}

			_on  = OnFun3;
			_on += OnFun2;
			_on += OnFun2;
			_on += OnFun2;
			_on += OnFun1;
			Debug.Log("*** 3-222-1 ***");
			if (_on != null) {
				_on ();
			}

			_on -= OnFun3;
			_on -= OnFun3;	//검색해서 내부에서 빼주는듯...
			_on -= OnFun2;
			_on -= OnFun2;
			_on -= OnFun2;
			Debug.Log("*** 3-222-1 <-33222 => 1***");
			if (_on != null) {
				_on ();
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
}
