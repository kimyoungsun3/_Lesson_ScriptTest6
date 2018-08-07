using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Struct{
	public class StructTest : MonoBehaviour {

		// Use this for initialization
		void Start () {
			SomeStruct s1 = new SomeStruct (1, Vector3.one);
			SomeStruct s2 = new SomeStruct (1, Vector3.one);
			SomeStruct s3 = new SomeStruct (2, Vector3.one);
			SomeStruct s4 = new SomeStruct (1, Vector3.one*2);
			Debug.Log (s1 == s2);
			Debug.Log (s1 == s3);
			Debug.Log (s1 == s4);
			Fun (s1);
			Fun (s2);
			Fun (s3);

		}

		void Fun(SomeStruct _s){
			if (_s)
				Debug.Log (true);
			else
				Debug.Log (false);

		}

		//-------------------------
		public struct SomeStruct{
			public int x;
			public Vector3 v;
			public SomeStruct(int _x, Vector3 _v){
				x = _x;
				v = _v;
			}

			public static bool operator == (SomeStruct _s1, SomeStruct _s2){
				return _s1.x == _s2.x && _s1.v == _s2.v;
			}

			public static bool operator != (SomeStruct _s1, SomeStruct _s2){
				return _s1.x != _s2.x || _s1.v != _s2.v;
			}

			public static implicit operator bool(SomeStruct _s){
				return _s.x == 1 && _s.v == Vector3.one;
			}
		}
	}
}
