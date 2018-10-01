using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inheritance{
	public class CStep1 {
		public void f1(){
			Debug.Log ("CStep1 f1()");
		}

		public virtual void f2(){
			Debug.Log ("CStep1 f2()");
		}

		public virtual void f3(){
			Debug.Log ("CStep1 f3()");
		}

		//abstract class 에서 생성됨...
		//public abstract void f4();
	}
}