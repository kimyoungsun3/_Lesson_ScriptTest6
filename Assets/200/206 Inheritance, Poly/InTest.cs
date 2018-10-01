using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inheritance{
	public class InTest : MonoBehaviour {

		// Use this for initialization
		void Start () {
			CStep1 _c1 = new CStep3 ();
			CStep2 _c2 = new CStep3 ();
			CStep3 _c3 = new CStep3 ();

			Debug.Log ("--CStep1 _c1 = new CStep3 ()--");
			_c1.f1 ();
			_c1.f2 ();
			_c1.f3 ();

			Debug.Log ("--CStep2 _c2 = new CStep3 ()--");
			_c2.f1 ();
			_c2.f2 ();
			_c2.f3 ();

			Debug.Log ("--CStep3 _c3 = new CStep3 ()--");
			_c3.f1 ();
			_c3.f2 ();
			_c3.f3 ();

			Debug.Log ("-- _c3 -> _c4(CStep1)으로 받기--");
			CStep1 _c4 = (CStep1) _c3;
			_c4.f1 ();
			_c4.f2 ();
			_c4.f3 ();
		}

	}
}
