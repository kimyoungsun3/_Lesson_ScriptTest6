using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PropertyTest{
	public class PropertyTest : MonoBehaviour {
		private int exp_;
		public int exp {
			get { return exp_; 	}
			set { exp_ = value; }
		}
		public int level {
			get {
				Debug.Log ("level 호출하기 전에 작업가능");
				return exp_ / 10; 
			}
		}
		void Start () {
			exp = 110;

			Debug.Log ("exp : " + exp);
			Debug.Log ("level : " + level);	
		}
	}
}