using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DelegateTest{
	public class DelegateOrder : MonoBehaviour {

		void Start () {
			VOID_FUN_VOID2 _cb;

			_cb  = OnFun1;
			_cb += OnFun2;
			_cb += OnFun3;
			if (_cb != null) {
				_cb ();
			}

			_cb  = OnFun3;
			_cb += OnFun2;
			_cb += OnFun1;
			if (_cb != null) {
				_cb ();
			}

			_cb  = OnFun3;
			_cb += OnFun2;
			_cb += OnFun2;
			_cb += OnFun2;
			_cb += OnFun1;
			if (_cb != null) {
				_cb ();
			}

			_cb -= OnFun3;
			_cb -= OnFun3;	//검색해서 내부에서 빼주는듯...
			_cb -= OnFun2;
			_cb -= OnFun2;
			_cb -= OnFun2;
			if (_cb != null) {
				_cb ();
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
