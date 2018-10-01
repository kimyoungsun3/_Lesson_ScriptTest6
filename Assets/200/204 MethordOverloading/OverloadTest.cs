using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OverloadTest{
	public class OverloadTest : MonoBehaviour {

		// Use this for initialization
		void Start () {
			Add (1, 1);
			Add (1f, 1f);
			Add (1, 1f);
			Add ("My", "Name");		
		}

		int Add(int x, int y){
			Debug.Log ("int add");
			return x + y;
		}

		float Add(float x, float y){
			Debug.Log ("float add");
			return x + y;
		}

		string Add(string x, string y){
			Debug.Log ("string add");
			return x + y;
		}
	}
}
