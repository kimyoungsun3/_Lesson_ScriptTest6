using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DelegateTest{
public class PopouSub : MonoBehaviour {
		VOID_FUN_VOID cb;

		void Start(){
			gameObject.SetActive (false);
		}

		public void SetCallback(VOID_FUN_VOID _cb){
			gameObject.SetActive (true);
			cb = _cb;
		}

		void OnMouseDown(){
			if (cb != null) {
				cb ();
				cb = null;
			}
		}
	}
	
}
