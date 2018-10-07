using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InheritanceNew{
	public class CStep2 : CStep1 {
		public CStep2(){
			Debug.Log ("CStep2 Constructor");
		}

		public new void f1(){
			Debug.Log ("CStep2 f1()");
		}

		//public override void f2(){
		//	Debug.Log ("CStep2 f2()");
		//}

		//public override void f3(){
		//	Debug.Log ("CStep2 f3()");
		//}

		public new void f4(){
			Debug.Log ("CStep2 f4()");
		}
	}
}
