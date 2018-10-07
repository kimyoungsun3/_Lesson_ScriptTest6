using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DelegateTest{
	public class DelegateSub : MonoBehaviour {

		void Start(){
			DelegateMaster.ins.cbClick += OnClickDisplay;
		}

		void OnClickDisplay(){
			Debug.Log (this + " OnClickDisplay");
		}
	}
}