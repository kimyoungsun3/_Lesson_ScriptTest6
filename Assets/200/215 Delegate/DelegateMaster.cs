using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DelegateTest{
	public class DelegateMaster : MonoBehaviour {
		public static DelegateMaster ins;
		public VOID_FUN_VOID onClick;

		void Awake(){
			ins = this;
		}

		void Start(){
			Debug.Log ("Mouse click and Event Call");
		}

		void Update () {
			if (Input.GetMouseButtonDown (0)) {
				if (onClick != null) {
					onClick ();
				}
			}
		}
	}
}
