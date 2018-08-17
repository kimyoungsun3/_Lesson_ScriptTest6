using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace statictest{
	public class Enemy3 : MonoBehaviour{

		void Start(){
			Debug.Log ("Enemy3:" + Enemy3.Add (1f, 2f));
		}


		public static float Add(float _x1, float _x2){
			return _x1 + _x2;
		}
	}
}
