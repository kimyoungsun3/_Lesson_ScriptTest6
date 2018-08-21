using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenerateTest{
	public class XXX{
		public int x;
		public XXX(){
			x = 2;
		}

		public int Fun(){
			x += 2;
			return x;
		}
	}

	public class GenerateTest : MonoBehaviour {

		// Use this for initialization
		void Start () {
			Debug.Log("method int :" + GetComXXX<int> (10));
			Debug.Log("method float :" + GetComXXX<float> (10.1f));

			Debug.Log("class :" + GetComXXX2<XXX> (new XXX()).Fun());

			Debug.Log("class :" + GetComXXX2<XXX> (new XXX()).Fun());
		}


		T GetComXXX<T>(T _t){
			return _t;
		}


		T GetComXXX2<T>(T _t) where T : class
		{
			return _t;
		}
	}
}
