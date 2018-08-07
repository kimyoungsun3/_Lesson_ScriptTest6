using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Struct{
	public class StructTest2 : MonoBehaviour {

		// Use this for initialization
		void Start () {
			SomeStruct2 s1 = new SomeStruct2 (1, Vector3.one);
			SomeStruct2 s2 = new SomeStruct2 (1, Vector3.one);
			SomeStruct2 s3 = new SomeStruct2 (1, Vector3.one*2);

			Debug.Log (s1 == s2);
			Debug.Log (s1 == s3);
			Debug.Log (s1 != s2);
			Debug.Log (s1 != s3);
			Debug.Log (s1);
			if (s1)
				Debug.Log ("true");
			else
				Debug.Log ("false");
		}

		//-----------------------------

		public struct SomeStruct1{
			public int x;
			public Vector3 v;
			public bool b;
			bool b2;
		}

		public struct SomeStruct2{
			public int x;
			public Vector3 v;
			public bool b;
			//bool b2;
			public SomeStruct2(int _x, Vector3 _v){
				x = _x;
				v = _v;
				b = false;
			}

			public static bool operator == (SomeStruct2 _s1, SomeStruct2 _s2){
				return _s1.x == _s2.x && _s1.v == _s2.v;
			}
			public static bool operator != (SomeStruct2 _s1, SomeStruct2 _s2){
				return _s1.x != _s2.x || _s1.v != _s2.v;
			}

			public static implicit operator bool(SomeStruct2 _s1){
				return _s1.b;
			}
		}
	}
}