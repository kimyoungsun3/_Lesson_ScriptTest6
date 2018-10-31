using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ValueAndReference{
	public class OtherScripts : MonoBehaviour {
		public Vector3 v;
		public Quaternion q;
		Vector3 v2;
		void Start(){
			v2 = new Vector3 (0, 0, 0);
		}
	}
}