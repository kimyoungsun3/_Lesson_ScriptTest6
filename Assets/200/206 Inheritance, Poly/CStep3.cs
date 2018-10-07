using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inheritance{
	public class CStep3 : CStep2 {
		public CStep3(){
			Debug.Log ("CStep3 Constructor");
		}

		public void f1(){
			Debug.Log ("CStep3 f1()");
		}

		public override void f2(){
			Debug.Log ("CStep3 f2()");
		}

		public override void f3(){
			Debug.Log ("CStep3 f3()");
		}

		//public override void f4(){
		//	Debug.Log ("CStep4 f4()");
		//}
	}
}