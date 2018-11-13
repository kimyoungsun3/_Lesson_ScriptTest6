using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListAndDictionary{
	public class CubeMaster : MonoBehaviour {
		public static CubeMaster ins; 
		public List<Transform> list = new List<Transform>();

		void Awake(){
			ins = this;
		}

		public void AddTransform(Transform _t){
			list.Add (_t);
		}
	}
}
