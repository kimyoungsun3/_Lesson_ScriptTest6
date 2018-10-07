using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InheritanceNew{
	public class InTest : MonoBehaviour {

		// Use this for initialization
		void Start () {

			Debug.Log ("--CStep1 _c1 = new CStep2 ()--");
			CStep1 _c1 = new CStep2 ();
			_c1.f1 ();
			_c1.f4 ();

			Debug.Log ("--CStep2 _c2 = new CStep2 ()--");
			CStep2 _c2 = new CStep2 ();
			_c2.f1 ();
			_c2.f4 ();

			Debug.Log ("--_c21 <- (CStep2)_c1--");
			CStep2 _c21 = (CStep2)_c1;
			_c21.f1 ();
			_c21.f4 ();

			Debug.Log ("--_c11 <- (CStep1)_c21--");
			CStep1 _c11 = (CStep1)_c1;
			_c11.f1 ();
			_c11.f4 ();
		}

	}
}
