using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComponentTest{
	public class AnotherScripts : MonoBehaviour {
		public int xxx;
		public void InitData(int _xxx){
			xxx = _xxx;
			Debug.Log ("AnotherScripts InitData");
		}
	}
}